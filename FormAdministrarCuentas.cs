using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAdministrarCuentas : Form
    {
        private const string NaturalezaDebito = "debito";
        private const string NaturalezaCredito = "credito";
        private const string EtiquetaDebito = "Débito";
        private const string EtiquetaCredito = "Crédito";
        private const string EstadoActivo = "activo";
        private const string EstadoInactivo = "inactivo";
        private const string EtiquetaActivo = "Activa";
        private const string EtiquetaInactivo = "Inactiva";

        private readonly string rutaCuentas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cuentas.json");
        private readonly string rutaCuentasProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Cuentas.json"));
        private JsonObject raizCatalogo;
        private JsonObject catalogo;
        private NodoRef cuentaSeleccionada;
        private bool cargando;
        private bool hayCambiosPendientes;
        private bool naturalezaManual;

        private class NodoRef
        {
            public string Nivel;
            public string Tipo;
            public string Grupo;
            public string Codigo;
            public string Nombre;
            public string Naturaleza;
            public decimal Saldo;
            public string Estado;
        }

        public FormAdministrarCuentas()
        {
            InitializeComponent();
        }

        private void FormAdministrarCuentas_Load(object sender, EventArgs e)
        {
            CargarCuentas();
            CargarEstados();
            if (cboEstado != null && cboEstado.Text.Trim().Length == 0)
                cboEstado.Text = EtiquetaActivo;
        }

        private void CargarCuentas()
        {
            try
            {
                if (!File.Exists(rutaCuentas))
                {
                    MessageBox.Show("No se encontró el archivo Cuentas.json.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                raizCatalogo = JsonNode.Parse(File.ReadAllText(rutaCuentas)) as JsonObject;
                catalogo = raizCatalogo?["catalogo_cuentas"] as JsonObject;

                if (catalogo == null)
                {
                    MessageBox.Show("El archivo Cuentas.json no contiene el catálogo de cuentas.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ActualizarComboTipos(null);
                ActualizarComboGrupos(null, null);
                CargarNaturalezas();
                CargarEstados();
                NormalizarCuentas();
                ConstruirArbol();
                LimpiarCampos();
                lblMensaje.Text = "Cuentas cargadas correctamente.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer Cuentas.json: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarCuentas()
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string contenido = raizCatalogo.ToJsonString(opciones);
            File.WriteAllText(rutaCuentas, contenido);
            ActualizarCopiaProyecto(contenido);
        }

        private void ActualizarCopiaProyecto(string contenido)
        {
            try
            {
                if (!File.Exists(rutaCuentasProyecto)) return;

                var nodo = JsonNode.Parse(File.ReadAllText(rutaCuentasProyecto)) as JsonObject;
                if (nodo == null || !(nodo["catalogo_cuentas"] is JsonObject)) return;

                File.WriteAllText(rutaCuentasProyecto, contenido);
            }
            catch
            {
            }
        }

        private static string NombreBonito(string clave)
        {
            return string.Join(" ", clave.Split('_')
                .Where(p => p.Length > 0)
                .Select(p => char.ToUpperInvariant(p[0]) + p.Substring(1)));
        }

        private string ClaveDesdeTexto(string texto, IEnumerable<string> existentes)
        {
            texto = (texto ?? "").Trim();
            if (texto.Length == 0) return "";

            string coincidencia = existentes.FirstOrDefault(
                k => string.Equals(NombreBonito(k), texto, StringComparison.OrdinalIgnoreCase));
            if (coincidencia != null) return coincidencia;

            return string.Join("_", texto.ToLowerInvariant()
                .Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries));
        }

        private static string EtiquetaNaturaleza(string clave)
        {
            return clave == NaturalezaCredito ? EtiquetaCredito : EtiquetaDebito;
        }

        private static string ClaveNaturalezaDesdeTexto(string texto)
        {
            return string.Equals((texto ?? "").Trim(), EtiquetaCredito, StringComparison.OrdinalIgnoreCase)
                ? NaturalezaCredito
                : NaturalezaDebito;
        }

        private static string NaturalezaSugerida(string claveTipo, string claveGrupo)
        {
            string tipo = (claveTipo ?? "").ToLowerInvariant();
            string grupo = (claveGrupo ?? "").ToLowerInvariant();

            if (grupo.Contains("gasto") || grupo.Contains("egreso")) return NaturalezaDebito;
            if (grupo.Contains("ingreso")) return NaturalezaCredito;
            if (tipo.Contains("activo")) return NaturalezaDebito;
            if (tipo.Contains("pasivo")) return NaturalezaCredito;
            if (tipo.Contains("patrimonio")) return NaturalezaCredito;
            return NaturalezaDebito;
        }

        private static string LeerNaturaleza(JsonNode cuenta)
        {
            if (!(cuenta?["naturaleza"] is JsonValue valor)) return null;
            if (!valor.TryGetValue(out string texto)) return null;

            texto = (texto ?? "").Trim().ToLowerInvariant();
            if (texto.Length == 0) return null;

            return texto == NaturalezaCredito ? NaturalezaCredito : NaturalezaDebito;
        }

        private static string LeerEstado(JsonNode cuenta)
        {
            if (!(cuenta?["estado"] is JsonValue valor)) return EstadoActivo;
            if (!valor.TryGetValue(out string texto)) return EstadoActivo;

            texto = (texto ?? "").Trim().ToLowerInvariant();
            if (texto.Length == 0) return EstadoActivo;

            return texto == EstadoInactivo ? EstadoInactivo : EstadoActivo;
        }

        private static decimal LeerSaldo(JsonNode cuenta)
        {
            if (!(cuenta?["saldo"] is JsonValue valor)) return 0m;

            if (valor.TryGetValue(out decimal numero)) return numero;
            if (valor.TryGetValue(out string texto)
                && decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out numero))
                return numero;

            return 0m;
        }

        private void ActualizarComboTipos(string seleccion)
        {
            bool estado = cargando;
            cargando = true;
            cboTipo.Items.Clear();
            foreach (KeyValuePair<string, JsonNode> tipo in catalogo.AsObject())
                cboTipo.Items.Add(NombreBonito(tipo.Key));
            if (seleccion != null) cboTipo.Text = seleccion;
            cargando = estado;
        }

        private void ActualizarComboGrupos(string claveTipo, string seleccion)
        {
            bool estado = cargando;
            cargando = true;
            cboGrupo.Items.Clear();
            if (claveTipo != null && catalogo[claveTipo] is JsonObject grupos)
            {
                foreach (KeyValuePair<string, JsonNode> grupo in grupos.AsObject())
                    cboGrupo.Items.Add(NombreBonito(grupo.Key));
            }
            if (seleccion != null) cboGrupo.Text = seleccion;
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

        private void CargarEstados()
        {
            bool estado = cargando;
            cargando = true;
            if (cboEstado != null)
            {
                cboEstado.Items.Clear();
                cboEstado.Items.Add(EtiquetaActivo);
                cboEstado.Items.Add(EtiquetaInactivo);
                cboEstado.Text = EtiquetaActivo;
            }
            cargando = estado;
        }

        private static string ClaveEstadoDesdeTexto(string texto)
        {
            return string.Equals((texto ?? "").Trim(), EtiquetaInactivo, StringComparison.OrdinalIgnoreCase)
                ? EstadoInactivo
                : EstadoActivo;
        }

        private static string EtiquetaEstado(string clave)
        {
            return clave == EstadoInactivo ? EtiquetaInactivo : EtiquetaActivo;
        }

        private void NormalizarCuentas()
        {
            foreach (KeyValuePair<string, JsonNode> tipo in catalogo.AsObject())
            {
                if (!(tipo.Value is JsonObject grupos)) continue;

                foreach (KeyValuePair<string, JsonNode> grupo in grupos.AsObject())
                {
                    if (!(grupo.Value is JsonArray cuentas)) continue;

                    foreach (JsonNode cta in cuentas)
                    {
                        if (!(cta is JsonObject cuenta)) continue;

                        if (LeerNaturaleza(cuenta) == null)
                            cuenta["naturaleza"] = NaturalezaSugerida(tipo.Key, grupo.Key);

                        if (cuenta["saldo"] == null)
                            cuenta["saldo"] = 0m;

                        if (cuenta["estado"] == null)
                            cuenta["estado"] = EstadoActivo;
                    }
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

            foreach (KeyValuePair<string, JsonNode> tipo in catalogo.AsObject())
            {
                var nodoTipo = new TreeNode(NombreBonito(tipo.Key))
                {
                    Tag = new NodoRef { Nivel = "tipo", Tipo = tipo.Key },
                    ToolTipText = "Tipo de cuenta: " + NombreBonito(tipo.Key)
                };

                if (tipo.Value is JsonObject grupos)
                {
                    foreach (KeyValuePair<string, JsonNode> grupo in grupos.AsObject())
                    {
                        var nodoGrupo = new TreeNode(NombreBonito(grupo.Key))
                        {
                            Tag = new NodoRef { Nivel = "grupo", Tipo = tipo.Key, Grupo = grupo.Key },
                            ToolTipText = "Grupo: " + NombreBonito(grupo.Key)
                        };

                        bool grupoTieneVisible = false;

                        if (grupo.Value is JsonArray cuentas)
                        {
                            foreach (JsonNode cta in cuentas)
                            {
                                string codigo = cta?["codigo"]?.GetValue<string>() ?? "";
                                string nombre = cta?["nombre"]?.GetValue<string>() ?? "";
                                string naturaleza = LeerNaturaleza(cta) ?? NaturalezaSugerida(tipo.Key, grupo.Key);
                                string etiquetaNaturaleza = EtiquetaNaturaleza(naturaleza);
                                string estado = LeerEstado(cta);
                                string etiquetaEstado = EtiquetaEstado(estado);
                                bool coincide = !hayFiltro
                                    || codigo.ToLowerInvariant().Contains(filtro)
                                    || nombre.ToLowerInvariant().Contains(filtro)
                                    || etiquetaNaturaleza.ToLowerInvariant().Contains(filtro)
                                    || etiquetaEstado.ToLowerInvariant().Contains(filtro)
                                    || NombreBonito(tipo.Key).ToLowerInvariant().Contains(filtro)
                                    || NombreBonito(grupo.Key).ToLowerInvariant().Contains(filtro);

                                if (!coincide) continue;

                                nodoGrupo.Nodes.Add(new TreeNode(codigo + " - " + nombre + " (" + etiquetaNaturaleza + ") - " + etiquetaEstado)
                                {
                                    Tag = new NodoRef
                                    {
                                        Nivel = "cuenta",
                                        Tipo = tipo.Key,
                                        Grupo = grupo.Key,
                                        Codigo = codigo,
                                        Nombre = nombre,
                                        Naturaleza = naturaleza,
                                        Saldo = LeerSaldo(cta),
                                        Estado = estado
                                    },
                                    ToolTipText = "Cuenta " + codigo + ": " + nombre
                                        + " | Naturaleza: " + etiquetaNaturaleza
                                        + " | Estado: " + etiquetaEstado
                                });
                                grupoTieneVisible = true;
                            }
                        }

                        if (grupoTieneVisible || !hayFiltro)
                        {
                            nodoTipo.Nodes.Add(nodoGrupo);
                        }
                    }
                }

                if (nodoTipo.Nodes.Count > 0)
                {
                    nodoRaiz.Nodes.Add(nodoTipo);
                }
            }

            treeCuentas.Nodes.Add(nodoRaiz);
            nodoRaiz.ExpandAll();
            treeCuentas.EndUpdate();
        }

        private void treeCuentas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cuentaSeleccionada = e.Node.Tag as NodoRef;
            if (cuentaSeleccionada == null) return;

            switch (cuentaSeleccionada.Nivel)
            {
                case "cuenta":
                    ActualizarComboTipos(NombreBonito(cuentaSeleccionada.Tipo));
                    ActualizarComboGrupos(cuentaSeleccionada.Tipo, NombreBonito(cuentaSeleccionada.Grupo));
                    txtCodigo.Text = cuentaSeleccionada.Codigo;
                    txtNombre.Text = cuentaSeleccionada.Nombre;
                    AplicarNaturalezaSeleccionada(cuentaSeleccionada.Naturaleza);
                    AplicarEstadoSeleccionado(cuentaSeleccionada.Estado ?? EstadoActivo);
                    numSaldo.Value = LimitarSaldo(cuentaSeleccionada.Saldo);
                    lblRuta.Text = NombreBonito(cuentaSeleccionada.Tipo) + " › " + NombreBonito(cuentaSeleccionada.Grupo);
                    lblMensaje.Text = "Cuenta consultada: " + cuentaSeleccionada.Codigo + " - " + cuentaSeleccionada.Nombre;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    break;

                case "grupo":
                    ActualizarComboTipos(NombreBonito(cuentaSeleccionada.Tipo));
                    ActualizarComboGrupos(cuentaSeleccionada.Tipo, NombreBonito(cuentaSeleccionada.Grupo));
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    LimpiarNaturalezaYSaldo();
                    AplicarNaturalezaSugerida();
                    AplicarEstadoDefecto();
                    lblRuta.Text = NombreBonito(cuentaSeleccionada.Tipo) + " › " + NombreBonito(cuentaSeleccionada.Grupo);
                    lblMensaje.Text = "Grupo seleccionado. Complete los datos para agregar una cuenta aquí.";
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    break;

                case "tipo":
                    ActualizarComboTipos(NombreBonito(cuentaSeleccionada.Tipo));
                    ActualizarComboGrupos(cuentaSeleccionada.Tipo, null);
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    LimpiarNaturalezaYSaldo();
                    AplicarNaturalezaSugerida();
                    AplicarEstadoDefecto();
                    lblRuta.Text = NombreBonito(cuentaSeleccionada.Tipo);
                    lblMensaje.Text = "Tipo seleccionado. Elija o escriba un grupo para agregar una cuenta.";
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
            string claveTipo = ClaveDesdeTexto(cboTipo.Text, catalogo.AsObject().Select(kv => kv.Key));
            ActualizarComboGrupos(claveTipo, null);
            AplicarNaturalezaSugerida();
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            AplicarNaturalezaSugerida();
        }

        private void cboNaturaleza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            naturalezaManual = true;
        }

        private void AplicarNaturalezaSugerida()
        {
            if (cargando || naturalezaManual || catalogo == null) return;

            string claveTipo = ClaveDesdeTexto(cboTipo.Text, catalogo.AsObject().Select(kv => kv.Key));
            if (claveTipo.Length == 0) return;

            string claveGrupo = ClaveDesdeTexto(cboGrupo.Text,
                catalogo[claveTipo] is JsonObject g ? g.AsObject().Select(kv => kv.Key) : Enumerable.Empty<string>());

            bool estado = cargando;
            cargando = true;
            cboNaturaleza.Text = EtiquetaNaturaleza(NaturalezaSugerida(claveTipo, claveGrupo));
            cargando = estado;
        }

        private void AplicarNaturalezaSeleccionada(string naturaleza)
        {
            if (string.IsNullOrEmpty(naturaleza)) naturaleza = NaturalezaDebito;

            bool estado = cargando;
            cargando = true;
            cboNaturaleza.Text = EtiquetaNaturaleza(naturaleza);
            cargando = estado;
            naturalezaManual = false;
        }

        private void AplicarEstadoSeleccionado(string estadoCuenta)
        {
            string clave = string.IsNullOrEmpty(estadoCuenta) ? EstadoActivo : estadoCuenta;
            bool estado = cargando;
            cargando = true;
            if (cboEstado != null)
                cboEstado.Text = EtiquetaEstado(clave);
            cargando = estado;
        }

        private void AplicarEstadoDefecto()
        {
            bool estado = cargando;
            cargando = true;
            if (cboEstado != null)
                cboEstado.Text = EtiquetaActivo;
            cargando = estado;
        }

        private void LimpiarNaturalezaYSaldo()
        {
            bool estado = cargando;
            cargando = true;
            cboNaturaleza.Text = "";
            cargando = estado;
            numSaldo.Value = 0m;
            naturalezaManual = false;
        }

        private decimal LimitarSaldo(decimal valor)
        {
            if (valor < numSaldo.Minimum) return numSaldo.Minimum;
            if (valor > numSaldo.Maximum) return numSaldo.Maximum;
            return valor;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ConstruirArbol();
        }

        private bool ValidarCampos(out string claveTipo, out string claveGrupo, out string codigo,
            out string nombre, out string naturaleza, out string estado, out decimal saldo)
        {
            claveTipo = claveGrupo = codigo = nombre = naturaleza = estado = EstadoActivo;
            saldo = 0m;

            if (cboTipo.Text.Trim().Length == 0)
            {
                lblMensaje.Text = "Seleccione o escriba el tipo de cuenta.";
                cboTipo.Focus();
                return false;
            }
            if (cboGrupo.Text.Trim().Length == 0)
            {
                lblMensaje.Text = "Seleccione o escriba el grupo de la cuenta.";
                cboGrupo.Focus();
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

            if (cboNaturaleza.Text.Trim().Length == 0)
            {
                AplicarNaturalezaSugerida();
            }
            if (cboNaturaleza.Text.Trim().Length == 0)
            {
                lblMensaje.Text = "Seleccione la naturaleza de la cuenta (Débito o Crédito).";
                cboNaturaleza.Focus();
                return false;
            }
            if (cboEstado != null && cboEstado.Text.Trim().Length == 0)
            {
                cboEstado.Text = EtiquetaActivo;
            }

            naturaleza = ClaveNaturalezaDesdeTexto(cboNaturaleza.Text);
            saldo = LimitarSaldo(numSaldo.Value);
            estado = cboEstado != null ? ClaveEstadoDesdeTexto(cboEstado.Text) : EstadoActivo;

            claveTipo = ClaveDesdeTexto(cboTipo.Text, catalogo.AsObject().Select(kv => kv.Key));
            claveGrupo = ClaveDesdeTexto(cboGrupo.Text,
                catalogo[claveTipo] is JsonObject g ? g.AsObject().Select(kv => kv.Key) : Enumerable.Empty<string>());

            if (claveTipo.Length == 0 || claveGrupo.Length == 0)
            {
                lblMensaje.Text = "El tipo y el grupo no pueden estar vacíos.";
                return false;
            }
            return true;
        }

        private JsonArray BuscarCuenta(string claveTipo, string claveGrupo, string codigo, out JsonObject cuenta)
        {
            cuenta = null;
            if (!(catalogo[claveTipo] is JsonObject grupos)) return null;
            if (!(grupos[claveGrupo] is JsonArray cuentas)) return null;

            foreach (JsonNode cta in cuentas)
            {
                if (cta?["codigo"]?.GetValue<string>() == codigo)
                {
                    cuenta = (JsonObject)cta;
                    return cuentas;
                }
            }
            return null;
        }

        private bool ExisteCodigo(string codigo, string tipoExcluido, string grupoExcluido, string codigoExcluido)
        {
            foreach (KeyValuePair<string, JsonNode> tipo in catalogo.AsObject())
            {
                if (!(tipo.Value is JsonObject grupos)) continue;

                foreach (KeyValuePair<string, JsonNode> grupo in grupos.AsObject())
                {
                    if (!(grupo.Value is JsonArray cuentas)) continue;

                    foreach (JsonNode cta in cuentas)
                    {
                        string cod = cta?["codigo"]?.GetValue<string>();
                        if (cod != codigo) continue;

                        bool esLaExcluida = tipo.Key == tipoExcluido
                            && grupo.Key == grupoExcluido
                            && cod == codigoExcluido;
                        if (!esLaExcluida) return true;
                    }
                }
            }
            return false;
        }

        private void SeleccionarCuenta(string claveTipo, string claveGrupo, string codigo)
        {
            if (treeCuentas.Nodes.Count == 0) return;

            foreach (TreeNode nodoTipo in treeCuentas.Nodes[0].Nodes)
            {
                var refTipo = nodoTipo.Tag as NodoRef;
                if (refTipo == null || refTipo.Tipo != claveTipo) continue;

                nodoTipo.Expand();
                foreach (TreeNode nodoGrupo in nodoTipo.Nodes)
                {
                    var refGrupo = nodoGrupo.Tag as NodoRef;
                    if (refGrupo == null || refGrupo.Grupo != claveGrupo) continue;

                    nodoGrupo.Expand();
                    foreach (TreeNode nodoCta in nodoGrupo.Nodes)
                    {
                        var refCta = nodoCta.Tag as NodoRef;
                        if (refCta != null && refCta.Codigo == codigo)
                        {
                            treeCuentas.SelectedNode = nodoCta;
                            return;
                        }
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(out string claveTipo, out string claveGrupo, out string codigo,
                    out string nombre, out string naturaleza, out string estado, out decimal saldo))
                    return;

                if (ExisteCodigo(codigo, claveTipo, claveGrupo, null))
                {
                    lblMensaje.Text = "Ya existe una cuenta con el código " + codigo + ".";
                    return;
                }

                JsonArray cuentas = ObtenerListaCuentas(claveTipo, claveGrupo);
                cuentas.Add(new JsonObject
                {
                    ["codigo"] = codigo,
                    ["nombre"] = nombre,
                    ["naturaleza"] = naturaleza,
                    ["saldo"] = saldo,
                    ["estado"] = estado
                });

                hayCambiosPendientes = true;
                ConstruirArbol();
                ActualizarComboTipos(NombreBonito(claveTipo));
                ActualizarComboGrupos(claveTipo, NombreBonito(claveGrupo));
                SeleccionarCuenta(claveTipo, claveGrupo, codigo);
                lblMensaje.Text = "Cuenta " + codigo + " agregada. Pulse \"Guardar Cambios\" para confirmar.";
            }
            catch (Exception ex)
            {
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
                if (!ValidarCampos(out string claveTipo, out string claveGrupo, out string codigo,
                    out string nombre, out string naturaleza, out string estado, out decimal saldo))
                    return;

                string codigoAntiguo = cuentaSeleccionada.Codigo;
                if (codigo != codigoAntiguo && ExisteCodigo(codigo, claveTipo, claveGrupo, codigoAntiguo))
                {
                    lblMensaje.Text = "Ya existe una cuenta con el código " + codigo + ".";
                    return;
                }

                JsonArray cuentasViejas = BuscarCuenta(cuentaSeleccionada.Tipo, cuentaSeleccionada.Grupo,
                    codigoAntiguo, out JsonObject cuentaVieja);
                if (cuentasViejas == null)
                {
                    lblMensaje.Text = "No se encontró la cuenta original en el archivo.";
                    return;
                }

                if (claveTipo == cuentaSeleccionada.Tipo && claveGrupo == cuentaSeleccionada.Grupo)
                {
                    cuentaVieja["codigo"] = codigo;
                    cuentaVieja["nombre"] = nombre;
                    cuentaVieja["naturaleza"] = naturaleza;
                    cuentaVieja["saldo"] = saldo;
                    cuentaVieja["estado"] = estado;
                }
                else
                {
                    cuentasViejas.Remove(cuentaVieja);
                    ObtenerListaCuentas(claveTipo, claveGrupo).Add(new JsonObject
                    {
                        ["codigo"] = codigo,
                        ["nombre"] = nombre,
                        ["naturaleza"] = naturaleza,
                        ["saldo"] = saldo,
                        ["estado"] = estado
                    });
                }

                hayCambiosPendientes = true;
                ConstruirArbol();
                ActualizarComboTipos(NombreBonito(claveTipo));
                ActualizarComboGrupos(claveTipo, NombreBonito(claveGrupo));
                SeleccionarCuenta(claveTipo, claveGrupo, codigo);
                lblMensaje.Text = "Cuenta modificada. Pulse \"Guardar Cambios\" para confirmar.";
            }
            catch (Exception ex)
            {
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
                    "¿Desea eliminar la cuenta " + cuentaSeleccionada.Codigo + " - " + cuentaSeleccionada.Nombre + "?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes) return;

                JsonArray cuentas = BuscarCuenta(cuentaSeleccionada.Tipo, cuentaSeleccionada.Grupo,
                    cuentaSeleccionada.Codigo, out JsonObject cuenta);
                if (cuentas == null)
                {
                    lblMensaje.Text = "No se encontró la cuenta en el archivo.";
                    return;
                }

                string codigoEliminado = cuentaSeleccionada.Codigo;
                cuentas.Remove(cuenta);
                hayCambiosPendientes = true;
                ConstruirArbol();
                LimpiarCampos();
                lblMensaje.Text = "Cuenta " + codigoEliminado + " eliminada. Pulse \"Guardar Cambios\" para confirmar.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la cuenta: " + ex.Message, "Error",
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

        private JsonArray ObtenerListaCuentas(string claveTipo, string claveGrupo)
        {
            if (!(catalogo[claveTipo] is JsonObject grupos))
            {
                grupos = new JsonObject();
                catalogo[claveTipo] = grupos;
            }
            if (!(grupos[claveGrupo] is JsonArray cuentas))
            {
                cuentas = new JsonArray();
                grupos[claveGrupo] = cuentas;
            }
            return cuentas;
        }

        private void LimpiarCampos()
        {
            bool estado = cargando;
            cargando = true;
            cboTipo.Text = "";
            cboGrupo.Text = "";
            cboNaturaleza.Text = "";
            if (cboEstado != null) cboEstado.Text = EtiquetaActivo;
            cargando = estado;
            txtCodigo.Clear();
            txtNombre.Clear();
            numSaldo.Value = 0m;
            naturalezaManual = false;
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
