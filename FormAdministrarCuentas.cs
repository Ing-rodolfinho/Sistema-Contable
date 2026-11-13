using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAdministrarCuentas : FormBase
    {
        private const string NaturalezaDebito = "debito";
        private const string NaturalezaCredito = "credito";
        private const string EtiquetaDebito = "Débito";
        private const string EtiquetaCredito = "Crédito";
        private const string EstadoActivo = "activo";
        private const string EstadoInactivo = "inactivo";

        private readonly string rutaCuentas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cuentas.json");
        private readonly string rutaCuentasProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Cuentas.json"));
        private JsonObject raizCatalogo;
        private JsonObject catalogo;
        private NodoRef cuentaSeleccionada;
        private bool cargando;
        private bool hayCambiosPendientes;

        private class NodoRef
        {
            public string Nivel;
            public string Tipo;
            public string Codigo;
            public string Nombre;
            public string Naturaleza;
            public string Estado;
        }

        public FormAdministrarCuentas()
        {
            InitializeComponent();
        }

        private string RutaCuentasActual
        {
            get { return DatosContables.ResolverRuta(rutaCuentas, rutaCuentasProyecto); }
        }

        private static bool CuentaTieneMovimientos(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo)) return false;

            string error;
            List<AsientoContable> asientos = DatosContables.CargarAsientos(out error);
            if (!string.IsNullOrEmpty(error)) return false;

            foreach (AsientoContable asiento in asientos)
            {
                foreach (PartidaContable partida in asiento.Partidas)
                {
                    if (string.Equals(partida.Cuenta, codigo, StringComparison.OrdinalIgnoreCase))
                        return true;
                }
            }
            return false;
        }

        private void FormAdministrarCuentas_Load(object sender, EventArgs e)
        {
            PrepararContenido();
        }

        protected override void OnPrepararContenido()
        {
            CargarCuentas();
        }

        private void CargarCuentas()
        {
            try
            {
                raizCatalogo = null;
                catalogo = null;

                string ruta = RutaCuentasActual;
                if (!File.Exists(ruta))
                {
                    MessageBox.Show("No se encontró el archivo Cuentas.json.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                raizCatalogo = JsonNode.Parse(File.ReadAllText(ruta)) as JsonObject;
                catalogo = raizCatalogo?["catalogo_cuentas"] as JsonObject;

                if (catalogo == null)
                {
                    MessageBox.Show("El archivo Cuentas.json no contiene el catálogo de cuentas.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // El formato viejo (tipo -> grupo -> arreglo) se convierte en memoria
                // al formato plano nuevo (tipo -> arreglo). Al guardar se escribe plano.
                MigrarCatalogoAFormatoPlano();

                ActualizarComboTipos(null);
                CargarNaturalezas();
                NormalizarCuentas();
                ConstruirArbol();
                CargarCuentasEliminadas();
                LimpiarCampos();
                lblMensaje.Text = "Cuentas cargadas correctamente.";
            }
            catch (Exception ex)
            {
                ManejadorErrores.Registrar(ex, "Administrar Cuentas: error al leer Cuentas.json");
                MessageBox.Show("Error al leer Cuentas.json: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarCuentas()
        {
            if (raizCatalogo == null) throw new InvalidOperationException("No hay datos para guardar.");

            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string contenido = raizCatalogo.ToJsonString(opciones);
            string ruta = RutaCuentasActual;

            DatosContables.GuardarJsonSeguro(ruta, contenido);
            ActualizarCopiaProyecto(contenido, ruta);
        }

        private void ActualizarCopiaProyecto(string contenido, string rutaGuardada)
        {
            try
            {
                if (string.Equals(rutaGuardada, rutaCuentasProyecto, StringComparison.OrdinalIgnoreCase)
                    || !File.Exists(rutaCuentasProyecto))
                    return;

                var nodo = JsonNode.Parse(File.ReadAllText(rutaCuentasProyecto)) as JsonObject;
                if (nodo == null || !(nodo["catalogo_cuentas"] is JsonObject)) return;

                DatosContables.GuardarJsonSeguro(rutaCuentasProyecto, contenido);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Convierte el catálogo viejo con grupos al esquema plano de seis tipos.
        /// Si el archivo ya está plano, solo normaliza y reemplaza la raíz.
        /// </summary>
        private void MigrarCatalogoAFormatoPlano()
        {
            var plano = new JsonObject();
            foreach (string tipo in DatosContables.TiposCuenta)
                plano[tipo] = new JsonArray();

            var codigos = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (KeyValuePair<string, JsonNode> entrada in catalogo)
            {
                string tipoPadre = DatosContables.NormalizarTipo(entrada.Key);

                if (entrada.Value is JsonArray cuentasPlanas)
                {
                    if (tipoPadre == null) continue;
                    AgregarCuentasPlano(plano, tipoPadre, cuentasPlanas, codigos);
                    continue;
                }

                if (!(entrada.Value is JsonObject grupos)) continue;

                foreach (KeyValuePair<string, JsonNode> grupo in grupos)
                {
                    if (!(grupo.Value is JsonArray cuentas)) continue;

                    string tipo = DatosContables.NormalizarTipo(grupo.Key) ?? tipoPadre;
                    if (tipo == null) continue;

                    AgregarCuentasPlano(plano, tipo, cuentas, codigos);
                }
            }

            raizCatalogo["catalogo_cuentas"] = plano;
            catalogo = plano;
        }

        private static void AgregarCuentasPlano(JsonObject plano, string tipo, JsonArray cuentas,
            HashSet<string> codigos)
        {
            JsonArray destino = plano[tipo] as JsonArray;
            if (destino == null)
            {
                destino = new JsonArray();
                plano[tipo] = destino;
            }

            foreach (JsonNode nodo in cuentas)
            {
                if (!(nodo is JsonObject cuenta)) continue;

                string codigo = LeerTexto(cuenta, "codigo").Trim();
                if (codigo.Length == 0) continue;
                if (!codigos.Add(codigo)) continue;

                destino.Add(new JsonObject
                {
                    ["codigo"] = codigo,
                    ["nombre"] = LeerTexto(cuenta, "nombre").Trim(),
                    ["naturaleza"] = NaturalezaSugerida(tipo),
                    ["estado"] = LeerEstado(cuenta)
                });
            }
        }

        private static string LeerTexto(JsonObject objeto, string clave)
        {
            if (objeto == null || !(objeto[clave] is JsonValue valor)) return string.Empty;
            string texto;
            return valor.TryGetValue(out texto) ? (texto ?? string.Empty) : string.Empty;
        }

        /// <summary>
        /// La naturaleza se determina automáticamente por el tipo de cuenta:
        /// Activo, Costos y Gastos son de débito; Pasivo, Capital/Patrimonio e Ingresos de crédito.
        /// </summary>
        private static string NaturalezaSugerida(string claveTipo)
        {
            switch (DatosContables.NormalizarTipo(claveTipo))
            {
                case DatosContables.TipoPasivo:
                case DatosContables.TipoCapitalPatrimonio:
                case DatosContables.TipoIngresos:
                    return NaturalezaCredito;
                default:
                    return NaturalezaDebito;
            }
        }

        private static string LeerEstado(JsonNode cuenta)
        {
            if (!(cuenta?["estado"] is JsonValue valor)) return EstadoActivo;
            if (!valor.TryGetValue(out string texto)) return EstadoActivo;

            texto = (texto ?? "").Trim().ToLowerInvariant();
            if (texto.Length == 0) return EstadoActivo;

            return texto == EstadoInactivo ? EstadoInactivo : EstadoActivo;
        }

        private static string EtiquetaNaturaleza(string clave)
        {
            return clave == NaturalezaCredito ? EtiquetaCredito : EtiquetaDebito;
        }

        private static string ClaveTipoDesdeTexto(string texto)
        {
            string clave = DatosContables.NormalizarTipo(texto);
            if (clave != null) return clave;

            foreach (string tipo in DatosContables.TiposCuenta)
            {
                if (string.Equals(DatosContables.EtiquetaTipo(tipo), (texto ?? "").Trim(),
                    StringComparison.OrdinalIgnoreCase))
                    return tipo;
            }

            return string.Empty;
        }

        private void ActualizarComboTipos(string seleccion)
        {
            bool estado = cargando;
            cargando = true;
            cboTipo.Items.Clear();
            foreach (string tipo in DatosContables.TiposCuenta)
                cboTipo.Items.Add(DatosContables.EtiquetaTipo(tipo));
            if (seleccion != null) cboTipo.Text = seleccion;
            cargando = estado;
        }

        private void CargarNaturalezas()
        {
            bool estado = cargando;
            cargando = true;
            cboNaturaleza.Items.Clear();
            cboNaturaleza.Items.Add(EtiquetaDebito);
            cboNaturaleza.Items.Add(EtiquetaCredito);
            cboNaturaleza.Text = "";
            cargando = estado;
        }

        private void NormalizarCuentas()
        {
            foreach (string tipo in DatosContables.TiposCuenta)
            {
                JsonArray cuentas = ObtenerListaCuentas(tipo, false);
                if (cuentas == null) continue;

                foreach (JsonNode nodo in cuentas)
                {
                    if (!(nodo is JsonObject cuenta)) continue;

                    // La naturaleza depende siempre del tipo, no se guarda una elección manual.
                    cuenta["naturaleza"] = NaturalezaSugerida(tipo);

                    // El saldo dejó de almacenarse en el catálogo: se calcula con los asientos.
                    if (cuenta.ContainsKey("saldo"))
                        cuenta.Remove("saldo");

                    cuenta["estado"] = LeerEstado(cuenta);
                }
            }
        }

        private void ConstruirArbol()
        {
            string filtro = txtBuscar.Text.Trim().ToLowerInvariant();
            bool hayFiltro = filtro.Length > 0;

            treeCuentas.BeginUpdate();
            treeCuentas.Nodes.Clear();

            var nodoRaiz = new TreeNode("Catálogo de Cuentas")
            {
                Tag = new NodoRef { Nivel = "raiz" }
            };

            foreach (string tipo in DatosContables.TiposCuenta)
            {
                string etiquetaTipo = DatosContables.EtiquetaTipo(tipo);
                var nodoTipo = new TreeNode(etiquetaTipo)
                {
                    Tag = new NodoRef { Nivel = "tipo", Tipo = tipo },
                    ToolTipText = "Tipo de cuenta: " + etiquetaTipo
                };

                JsonArray cuentas = ObtenerListaCuentas(tipo, false);
                bool tipoTieneVisible = false;

                if (cuentas != null)
                {
                    foreach (JsonNode nodo in cuentas)
                    {
                        if (!(nodo is JsonObject cta)) continue;

                        // Las cuentas eliminadas (inactivas) solo se muestran en su sección.
                        if (LeerEstado(cta) == EstadoInactivo) continue;

                        string codigo = LeerTexto(cta, "codigo").Trim();
                        string nombre = LeerTexto(cta, "nombre").Trim();
                        string naturaleza = NaturalezaSugerida(tipo);
                        string etiquetaNaturaleza = EtiquetaNaturaleza(naturaleza);

                        bool coincide = !hayFiltro
                            || codigo.ToLowerInvariant().Contains(filtro)
                            || nombre.ToLowerInvariant().Contains(filtro)
                            || etiquetaNaturaleza.ToLowerInvariant().Contains(filtro)
                            || etiquetaTipo.ToLowerInvariant().Contains(filtro);

                        if (!coincide) continue;

                        nodoTipo.Nodes.Add(new TreeNode(codigo + " - " + nombre + " ("
                            + etiquetaNaturaleza + ")")
                        {
                            Tag = new NodoRef
                            {
                                Nivel = "cuenta",
                                Tipo = tipo,
                                Codigo = codigo,
                                Nombre = nombre,
                                Naturaleza = naturaleza,
                                Estado = EstadoActivo
                            },
                            ToolTipText = "Cuenta " + codigo + ": " + nombre
                                + " | Tipo: " + etiquetaTipo
                                + " | Naturaleza: " + etiquetaNaturaleza
                        });
                        tipoTieneVisible = true;
                    }
                }

                if (tipoTieneVisible || !hayFiltro)
                {
                    nodoRaiz.Nodes.Add(nodoTipo);
                }
            }

            treeCuentas.Nodes.Add(nodoRaiz);
            nodoRaiz.ExpandAll();
            treeCuentas.EndUpdate();
        }

        private void CargarCuentasEliminadas()
        {
            lvEliminadas.BeginUpdate();
            lvEliminadas.Items.Clear();

            if (catalogo != null)
            {
                foreach (string tipo in DatosContables.TiposCuenta)
                {
                    JsonArray cuentas = ObtenerListaCuentas(tipo, false);
                    if (cuentas == null) continue;

                    foreach (JsonNode nodo in cuentas)
                    {
                        if (!(nodo is JsonObject cuenta)) continue;
                        if (LeerEstado(cuenta) != EstadoInactivo) continue;

                        string codigo = LeerTexto(cuenta, "codigo").Trim();
                        string nombre = LeerTexto(cuenta, "nombre").Trim();

                        var item = new ListViewItem(codigo);
                        item.SubItems.Add(nombre);
                        item.SubItems.Add(DatosContables.EtiquetaTipo(tipo));
                        item.Tag = new NodoRef
                        {
                            Nivel = "cuenta",
                            Tipo = tipo,
                            Codigo = codigo,
                            Nombre = nombre,
                            Naturaleza = NaturalezaSugerida(tipo),
                            Estado = EstadoInactivo
                        };
                        lvEliminadas.Items.Add(item);
                    }
                }
            }

            lvEliminadas.EndUpdate();
            ActualizarEstadoBotonReactivar();
        }

        private void ActualizarEstadoBotonReactivar()
        {
            btnReactivar.Enabled = lvEliminadas.SelectedItems.Count > 0;
        }

        private void treeCuentas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cuentaSeleccionada = e.Node.Tag as NodoRef;
            if (cuentaSeleccionada == null) return;

            switch (cuentaSeleccionada.Nivel)
            {
                case "cuenta":
                    ActualizarComboTipos(DatosContables.EtiquetaTipo(cuentaSeleccionada.Tipo));
                    txtCodigo.Text = cuentaSeleccionada.Codigo;
                    txtNombre.Text = cuentaSeleccionada.Nombre;
                    MostrarNaturaleza(NaturalezaSugerida(cuentaSeleccionada.Tipo));
                    lblRuta.Text = DatosContables.EtiquetaTipo(cuentaSeleccionada.Tipo);
                    lblMensaje.Text = "Cuenta consultada: " + cuentaSeleccionada.Codigo + " - "
                        + cuentaSeleccionada.Nombre;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    break;

                case "tipo":
                    ActualizarComboTipos(DatosContables.EtiquetaTipo(cuentaSeleccionada.Tipo));
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    LimpiarNaturaleza();
                    AplicarNaturalezaSugerida();
                    lblRuta.Text = DatosContables.EtiquetaTipo(cuentaSeleccionada.Tipo);
                    lblMensaje.Text = "Tipo seleccionado. Complete los datos para agregar una cuenta aquí.";
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    break;

                default:
                    LimpiarCampos();
                    lblRuta.Text = "Seleccione una cuenta en el árbol para consultarla";
                    break;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            AplicarNaturalezaSugerida();
        }

        private void AplicarNaturalezaSugerida()
        {
            if (cargando || catalogo == null) return;

            string claveTipo = ClaveTipoDesdeTexto(cboTipo.Text);
            if (claveTipo.Length == 0) return;

            MostrarNaturaleza(NaturalezaSugerida(claveTipo));
        }

        private void MostrarNaturaleza(string naturaleza)
        {
            bool estado = cargando;
            cargando = true;
            cboNaturaleza.Text = EtiquetaNaturaleza(naturaleza);
            cargando = estado;
        }

        private void LimpiarNaturaleza()
        {
            bool estado = cargando;
            cargando = true;
            cboNaturaleza.Text = "";
            cargando = estado;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ConstruirArbol();
        }

        private bool ValidarCampos(out string claveTipo, out string codigo,
            out string nombre, out string naturaleza)
        {
            claveTipo = codigo = nombre = naturaleza = string.Empty;

            if (cboTipo.Text.Trim().Length == 0)
            {
                lblMensaje.Text = "Seleccione el tipo de cuenta.";
                cboTipo.Focus();
                return false;
            }

            claveTipo = ClaveTipoDesdeTexto(cboTipo.Text);
            if (claveTipo.Length == 0)
            {
                lblMensaje.Text = "El tipo de cuenta seleccionado no es válido.";
                cboTipo.Focus();
                return false;
            }

            codigo = txtCodigo.Text.Trim();
            nombre = txtNombre.Text.Trim();

            if (codigo.Length == 0)
            {
                lblMensaje.Text = "Escriba el código de la cuenta.";
                txtCodigo.Focus();
                return false;
            }
            if (!codigo.All(char.IsLetterOrDigit))
            {
                lblMensaje.Text = "El código solo puede contener letras y números.";
                txtCodigo.Focus();
                return false;
            }
            if (nombre.Length == 0)
            {
                lblMensaje.Text = "Escriba el nombre de la cuenta.";
                txtNombre.Focus();
                return false;
            }

            // La naturaleza se asigna automáticamente según el tipo seleccionado.
            naturaleza = NaturalezaSugerida(claveTipo);
            MostrarNaturaleza(naturaleza);
            return true;
        }

        private JsonArray BuscarCuenta(string claveTipo, string codigo, out JsonObject cuenta)
        {
            cuenta = null;
            JsonArray cuentas = ObtenerListaCuentas(claveTipo, false);
            if (cuentas == null) return null;

            foreach (JsonNode cta in cuentas)
            {
                if (!(cta is JsonObject objeto)) continue;

                string cod = LeerTexto(objeto, "codigo").Trim();
                if (string.Equals(cod, codigo, StringComparison.OrdinalIgnoreCase))
                {
                    cuenta = objeto;
                    return cuentas;
                }
            }
            return null;
        }

        private bool ExisteCodigo(string codigo, string codigoExcluido)
        {
            foreach (string tipo in DatosContables.TiposCuenta)
            {
                JsonArray cuentas = ObtenerListaCuentas(tipo, false);
                if (cuentas == null) continue;

                foreach (JsonNode cta in cuentas)
                {
                    if (!(cta is JsonObject objeto)) continue;

                    string cod = LeerTexto(objeto, "codigo").Trim();
                    if (!string.Equals(cod, codigo, StringComparison.OrdinalIgnoreCase)) continue;

                    if (!string.IsNullOrEmpty(codigoExcluido)
                        && string.Equals(cod, codigoExcluido, StringComparison.OrdinalIgnoreCase))
                        continue;

                    return true;
                }
            }
            return false;
        }

        private void SeleccionarCuenta(string claveTipo, string codigo)
        {
            if (treeCuentas.Nodes.Count == 0) return;

            foreach (TreeNode nodoTipo in treeCuentas.Nodes[0].Nodes)
            {
                var refTipo = nodoTipo.Tag as NodoRef;
                if (refTipo == null || refTipo.Tipo != claveTipo) continue;

                nodoTipo.Expand();
                foreach (TreeNode nodoCta in nodoTipo.Nodes)
                {
                    var refCta = nodoCta.Tag as NodoRef;
                    if (refCta != null && string.Equals(refCta.Codigo, codigo,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        treeCuentas.SelectedNode = nodoCta;
                        return;
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(out string claveTipo, out string codigo,
                    out string nombre, out string naturaleza))
                    return;

                if (ExisteCodigo(codigo, null))
                {
                    lblMensaje.Text = "Ya existe una cuenta con el código " + codigo + ".";
                    return;
                }

                JsonArray cuentas = ObtenerListaCuentas(claveTipo, true);
                cuentas.Add(new JsonObject
                {
                    ["codigo"] = codigo,
                    ["nombre"] = nombre,
                    ["naturaleza"] = naturaleza,
                    ["estado"] = EstadoActivo
                });

                hayCambiosPendientes = true;
                ConstruirArbol();
                ActualizarComboTipos(DatosContables.EtiquetaTipo(claveTipo));
                SeleccionarCuenta(claveTipo, codigo);
                lblMensaje.Text = "Cuenta " + codigo + " agregada. Pulse \"Guardar Cambios\" para confirmar.";
            }
            catch (Exception ex)
            {
                ManejadorErrores.Registrar(ex, "Administrar Cuentas: error al agregar la cuenta");
                MessageBox.Show("Error al agregar la cuenta: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cuentaSeleccionada == null || cuentaSeleccionada.Nivel != "cuenta")
                {
                    lblMensaje.Text = "Seleccione la cuenta que desea modificar.";
                    return;
                }
                if (!ValidarCampos(out string claveTipo, out string codigo,
                    out string nombre, out string naturaleza))
                    return;

                string codigoAntiguo = cuentaSeleccionada.Codigo;
                if (!string.Equals(codigo, codigoAntiguo, StringComparison.OrdinalIgnoreCase)
                    && CuentaTieneMovimientos(codigoAntiguo))
                {
                    lblMensaje.Text = "No se puede cambiar el código de la cuenta " + codigoAntiguo
                        + " porque tiene movimientos registrados en operaciones.json. "
                        + "Puede cambiar el nombre o el tipo.";
                    return;
                }

                if (!string.Equals(codigo, codigoAntiguo, StringComparison.OrdinalIgnoreCase)
                    && ExisteCodigo(codigo, codigoAntiguo))
                {
                    lblMensaje.Text = "Ya existe una cuenta con el código " + codigo + ".";
                    return;
                }

                JsonArray cuentasViejas = BuscarCuenta(cuentaSeleccionada.Tipo, codigoAntiguo,
                    out JsonObject cuentaVieja);
                if (cuentasViejas == null || cuentaVieja == null)
                {
                    lblMensaje.Text = "No se encontró la cuenta original en el archivo.";
                    return;
                }

                string estadoActual = LeerEstado(cuentaVieja);

                if (string.Equals(claveTipo, cuentaSeleccionada.Tipo, StringComparison.OrdinalIgnoreCase))
                {
                    cuentaVieja["codigo"] = codigo;
                    cuentaVieja["nombre"] = nombre;
                    cuentaVieja["naturaleza"] = naturaleza;
                }
                else
                {
                    cuentasViejas.Remove(cuentaVieja);
                    ObtenerListaCuentas(claveTipo, true).Add(new JsonObject
                    {
                        ["codigo"] = codigo,
                        ["nombre"] = nombre,
                        ["naturaleza"] = naturaleza,
                        ["estado"] = estadoActual
                    });
                }

                hayCambiosPendientes = true;
                ConstruirArbol();
                ActualizarComboTipos(DatosContables.EtiquetaTipo(claveTipo));
                SeleccionarCuenta(claveTipo, codigo);
                lblMensaje.Text = "Cuenta modificada. Pulse \"Guardar Cambios\" para confirmar.";
            }
            catch (Exception ex)
            {
                ManejadorErrores.Registrar(ex, "Administrar Cuentas: error al modificar la cuenta");
                MessageBox.Show("Error al modificar la cuenta: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cuentaSeleccionada == null || cuentaSeleccionada.Nivel != "cuenta")
                {
                    lblMensaje.Text = "Seleccione la cuenta que desea eliminar.";
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar la cuenta " + cuentaSeleccionada.Codigo + " - "
                    + cuentaSeleccionada.Nombre + "?\n\n"
                    + "La cuenta no se borrará del catálogo: pasará a la sección "
                    + "\"Cuentas eliminadas\" y podrá reactivarla cuando lo necesite.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes) return;

                JsonArray cuentas = BuscarCuenta(cuentaSeleccionada.Tipo, cuentaSeleccionada.Codigo,
                    out JsonObject cuenta);
                if (cuentas == null || cuenta == null)
                {
                    lblMensaje.Text = "No se encontró la cuenta en el archivo.";
                    return;
                }

                string codigoEliminado = cuentaSeleccionada.Codigo;
                cuenta["estado"] = EstadoInactivo;
                hayCambiosPendientes = true;
                ConstruirArbol();
                CargarCuentasEliminadas();
                LimpiarCampos();
                lblMensaje.Text = "Cuenta " + codigoEliminado + " eliminada. Puede restaurarla desde "
                    + "\"Cuentas eliminadas\". Pulse \"Guardar Cambios\" para confirmar.";
            }
            catch (Exception ex)
            {
                ManejadorErrores.Registrar(ex, "Administrar Cuentas: error al eliminar la cuenta");
                MessageBox.Show("Error al eliminar la cuenta: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            ReactivarSeleccionada();
        }

        private void lvEliminadas_DoubleClick(object sender, EventArgs e)
        {
            ReactivarSeleccionada();
        }

        private void lvEliminadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonReactivar();
        }

        private void ReactivarSeleccionada()
        {
            try
            {
                if (lvEliminadas.SelectedItems.Count == 0)
                {
                    lblMensaje.Text = "Seleccione una cuenta eliminada para reactivarla.";
                    return;
                }

                var referencia = lvEliminadas.SelectedItems[0].Tag as NodoRef;
                if (referencia == null) return;

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea reactivar la cuenta " + referencia.Codigo + " - "
                    + referencia.Nombre + "?",
                    "Confirmar reactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes) return;

                JsonArray cuentas = BuscarCuenta(referencia.Tipo, referencia.Codigo,
                    out JsonObject cuenta);
                if (cuentas == null || cuenta == null)
                {
                    lblMensaje.Text = "No se encontró la cuenta en el archivo.";
                    return;
                }

                cuenta["estado"] = EstadoActivo;
                hayCambiosPendientes = true;
                ConstruirArbol();
                CargarCuentasEliminadas();
                ActualizarComboTipos(DatosContables.EtiquetaTipo(referencia.Tipo));
                SeleccionarCuenta(referencia.Tipo, referencia.Codigo);
                lblMensaje.Text = "Cuenta " + referencia.Codigo
                    + " reactivada. Pulse \"Guardar Cambios\" para confirmar.";
            }
            catch (Exception ex)
            {
                ManejadorErrores.Registrar(ex, "Administrar Cuentas: error al reactivar la cuenta");
                MessageBox.Show("Error al reactivar la cuenta: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            treeCuentas.SelectedNode = null;
            LimpiarCampos();
            lblMensaje.Text = "Campos limpiados.";
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (catalogo == null)
                {
                    lblMensaje.Text = "No hay cuentas cargadas para guardar.";
                    return;
                }

                GuardarCuentas();
                hayCambiosPendientes = false;
                lblMensaje.Text = "Cambios guardados correctamente en Cuentas.json.";
            }
            catch (Exception ex)
            {
                ManejadorErrores.Registrar(ex, "Administrar Cuentas: error al guardar los cambios");
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdministrarCuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!hayCambiosPendientes) return;

            DialogResult respuesta = MessageBox.Show(
                "Hay cambios sin guardar. ¿Desea guardarlos antes de cerrar?",
                "Cambios sin guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    GuardarCuentas();
                    hayCambiosPendientes = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (respuesta == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private JsonArray ObtenerListaCuentas(string claveTipo, bool crear)
        {
            JsonArray cuentas = catalogo[claveTipo] as JsonArray;
            if (cuentas == null && crear)
            {
                cuentas = new JsonArray();
                catalogo[claveTipo] = cuentas;
            }
            return cuentas;
        }

        private void LimpiarCampos()
        {
            bool estado = cargando;
            cargando = true;
            cboTipo.Text = "";
            cboNaturaleza.Text = "";
            cargando = estado;
            txtCodigo.Clear();
            txtNombre.Clear();
            cuentaSeleccionada = null;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void tlpArbol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDetalleTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
