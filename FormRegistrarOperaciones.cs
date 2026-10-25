using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormRegistrarOperaciones : FormBase
    {
        private const string NaturalezaDebito = "debito";
        private const string NaturalezaCredito = "credito";
        private const string EtiquetaDebito = "Débito";
        private const string EtiquetaCredito = "Crédito";
        private const string TipoDebe = "Debe";
        private const string TipoHaber = "Haber";

        private readonly string rutaOperaciones = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "operaciones.json");
        private readonly string rutaOperacionesProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "operaciones.json"));
        private readonly string rutaCuentas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cuentas.json");
        private readonly string rutaCuentasProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Cuentas.json"));

        private readonly List<Partida> partidas = new List<Partida>();
        private readonly List<CuentaItem> cuentas = new List<CuentaItem>();
        private JsonObject raizOperaciones;
        private JsonArray asientos;
        private JsonObject raizCuentas;

        private class CuentaItem
        {
            public string Codigo;
            public string Nombre;
            public string Naturaleza;

            public override string ToString()
            {
                string etiqueta = Naturaleza == NaturalezaCredito ? EtiquetaCredito : EtiquetaDebito;
                return Codigo + " - " + Nombre + " (" + etiqueta + ")";
            }
        }

        private class Partida
        {
            public string Codigo;
            public string Nombre;
            public string Naturaleza;
            public decimal Importe;
            public bool EsHaber;
        }

        public FormRegistrarOperaciones()
        {
            InitializeComponent();
        }

        private void FormRegistrarOperaciones_Load(object sender, EventArgs e)
        {
            SuspendLayout();
            if (tlpFondo != null) tlpFondo.SuspendLayout();
            SuspendTree(this);

            try
            {
                CargarTiposPartida();
                CargarCuentas();
                CargarOperaciones();
                PrepararNuevoAsiento();
            }
            finally
            {
                ResumeTree(this);
                if (tlpFondo != null) tlpFondo.ResumeLayout(true);
                ResumeLayout(true);
            }
        }

        private void SuspendTree(Control control)
        {
            if (control == null) return;
            control.SuspendLayout();
            foreach (Control child in control.Controls)
                SuspendTree(child);
        }

        private void ResumeTree(Control control)
        {
            if (control == null) return;
            foreach (Control child in control.Controls)
                ResumeTree(child);
            control.ResumeLayout(true);
        }

        private void CargarTiposPartida()
        {
            cboTipoPartida.Items.Clear();
            cboTipoPartida.Items.Add(TipoDebe);
            cboTipoPartida.Items.Add(TipoHaber);
            cboTipoPartida.SelectedIndex = 0;
        }

        private string ResolverRuta(string rutaPrincipal, string rutaProyecto)
        {
            if (File.Exists(rutaPrincipal)) return rutaPrincipal;
            if (File.Exists(rutaProyecto)) return rutaProyecto;
            return rutaPrincipal;
        }

        private static string LeerTexto(JsonObject objeto, string clave)
        {
            if (!(objeto?[clave] is JsonValue valor)) return "";
            return valor.TryGetValue(out string texto) ? (texto ?? "") : "";
        }

        private static decimal LeerDecimal(JsonObject objeto, string clave)
        {
            if (!(objeto?[clave] is JsonValue valor)) return 0m;

            if (valor.TryGetValue(out decimal numero)) return numero;
            if (valor.TryGetValue(out string texto)
                && decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out numero))
                return numero;

            return 0m;
        }

        private static int LeerEntero(JsonObject objeto, string clave)
        {
            if (!(objeto?[clave] is JsonValue valor)) return 0;

            if (valor.TryGetValue(out int numero)) return numero;
            if (valor.TryGetValue(out decimal decimalNumero)) return (int)decimalNumero;
            if (valor.TryGetValue(out string texto)
                && int.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out numero))
                return numero;

            return 0;
        }

        private static string LeerFecha(JsonObject objeto, string clave)
        {
            string texto = LeerTexto(objeto, clave);
            if (texto.Length == 0) return "";

            if (DateTime.TryParseExact(texto, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime fecha))
                return fecha.ToString("dd/MM/yyyy");

            return texto;
        }

        private void CargarCuentas()
        {
            try
            {
                string ruta = ResolverRuta(rutaCuentas, rutaCuentasProyecto);
                if (!File.Exists(ruta))
                {
                    MessageBox.Show("No se encontró el archivo Cuentas.json.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                raizCuentas = JsonNode.Parse(File.ReadAllText(ruta)) as JsonObject;
                cuentas.Clear();

                if (raizCuentas?["catalogo_cuentas"] is JsonObject catalogo)
                {
                    foreach (KeyValuePair<string, JsonNode> tipo in catalogo)
                    {
                        if (!(tipo.Value is JsonObject grupos)) continue;

                        foreach (KeyValuePair<string, JsonNode> grupo in grupos)
                        {
                            if (!(grupo.Value is JsonArray lista)) continue;

                            foreach (JsonNode nodo in lista)
                            {
                                if (!(nodo is JsonObject cuenta)) continue;

                                string codigo = LeerTexto(cuenta, "codigo").Trim();
                                if (codigo.Length == 0) continue;

                                string estadoCuenta = LeerTexto(cuenta, "estado").Trim().ToLowerInvariant();
                                if (estadoCuenta == "inactivo")
                                    continue;

                                string naturaleza = LeerTexto(cuenta, "naturaleza").Trim().ToLowerInvariant();
                                if (naturaleza != NaturalezaCredito) naturaleza = NaturalezaDebito;

                                cuentas.Add(new CuentaItem
                                {
                                    Codigo = codigo,
                                    Nombre = LeerTexto(cuenta, "nombre").Trim(),
                                    Naturaleza = naturaleza
                                });
                            }
                        }
                    }
                }

                cboCuenta.Items.Clear();
                foreach (CuentaItem cuenta in cuentas)
                    cboCuenta.Items.Add(cuenta);

                if (cboCuenta.Items.Count > 0)
                    cboCuenta.SelectedIndex = 0;

                lblMensaje.Text = "Catálogo de cuentas cargado (" + cuentas.Count + " cuentas).";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer Cuentas.json: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarOperaciones()
        {
            try
            {
                string ruta = ResolverRuta(rutaOperaciones, rutaOperacionesProyecto);

                if (File.Exists(ruta))
                    raizOperaciones = JsonNode.Parse(File.ReadAllText(ruta)) as JsonObject;

                if (raizOperaciones == null)
                    raizOperaciones = new JsonObject();

                if (raizOperaciones["asientos"] is JsonArray existentes)
                    asientos = existentes;
                else
                {
                    asientos = new JsonArray();
                    raizOperaciones["asientos"] = asientos;
                }

                ActualizarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer operaciones.json: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarOperaciones()
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string contenido = raizOperaciones.ToJsonString(opciones);

            File.WriteAllText(rutaOperaciones, contenido);
            ActualizarCopiaProyecto(contenido, rutaOperaciones, rutaOperacionesProyecto);
        }

        private void GuardarCuentas()
        {
            if (raizCuentas == null) return;

            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string contenido = raizCuentas.ToJsonString(opciones);

            File.WriteAllText(rutaCuentas, contenido);
            ActualizarCopiaProyecto(contenido, rutaCuentas, rutaCuentasProyecto);
        }

        private void ActualizarCopiaProyecto(string contenido, string rutaPrincipal, string rutaProyecto)
        {
            try
            {
                if (!File.Exists(rutaProyecto)) return;
                if (string.Equals(Path.GetFullPath(rutaProyecto), Path.GetFullPath(rutaPrincipal),
                    StringComparison.OrdinalIgnoreCase)) return;

                File.WriteAllText(rutaProyecto, contenido);
            }
            catch
            {
            }
        }

        private JsonObject BuscarCuentaJson(string codigo)
        {
            if (!(raizCuentas?["catalogo_cuentas"] is JsonObject catalogo)) return null;

            foreach (KeyValuePair<string, JsonNode> tipo in catalogo)
            {
                if (!(tipo.Value is JsonObject grupos)) continue;

                foreach (KeyValuePair<string, JsonNode> grupo in grupos)
                {
                    if (!(grupo.Value is JsonArray lista)) continue;

                    foreach (JsonNode nodo in lista)
                    {
                        if (nodo is JsonObject cuenta && LeerTexto(cuenta, "codigo") == codigo)
                            return cuenta;
                    }
                }
            }
            return null;
        }

        private void RefrescarPartidas()
        {
            dgvPartidas.Rows.Clear();

            foreach (Partida partida in partidas)
            {
                int indice = dgvPartidas.Rows.Add(
                    partida.Codigo,
                    partida.Nombre,
                    partida.EsHaber ? 0m : partida.Importe,
                    partida.EsHaber ? partida.Importe : 0m);

                dgvPartidas.Rows[indice].Tag = partida;
            }

            if (dgvPartidas.Rows.Count > 0)
                dgvPartidas.CurrentCell = dgvPartidas.Rows[dgvPartidas.Rows.Count - 1].Cells[0];

            ActualizarTotales();
        }

        private void ActualizarTotales()
        {
            decimal totalDebe = 0m;
            decimal totalHaber = 0m;

            foreach (Partida partida in partidas)
            {
                if (partida.EsHaber) totalHaber += partida.Importe;
                else totalDebe += partida.Importe;
            }

            decimal diferencia = totalDebe - totalHaber;

            lblTotalDebe.Text = "Total Debe: " + totalDebe.ToString("N2");
            lblTotalHaber.Text = "Total Haber: " + totalHaber.ToString("N2");
            lblDiferencia.Text = "Diferencia: " + diferencia.ToString("N2");
            lblDiferencia.ForeColor = diferencia == 0m ? Color.SeaGreen : Color.Firebrick;
        }

        private void btnAgregarPartida_Click(object sender, EventArgs e)
        {
            var cuenta = cboCuenta.SelectedItem as CuentaItem;
            if (cuenta == null)
            {
                lblMensaje.Text = "Seleccione la cuenta de la partida.";
                cboCuenta.Focus();
                return;
            }

            if (numImporte.Value <= 0m)
            {
                lblMensaje.Text = "El importe de la partida debe ser mayor que cero.";
                numImporte.Focus();
                return;
            }

            string tipo = cboTipoPartida.Text.Trim();
            if (tipo.Length == 0)
            {
                lblMensaje.Text = "Seleccione Debe o Haber para la partida.";
                cboTipoPartida.Focus();
                return;
            }

            var partida = new Partida
            {
                Codigo = cuenta.Codigo,
                Nombre = cuenta.Nombre,
                Naturaleza = cuenta.Naturaleza,
                Importe = numImporte.Value,
                EsHaber = string.Equals(tipo, TipoHaber, StringComparison.OrdinalIgnoreCase)
            };

            partidas.Add(partida);
            RefrescarPartidas();
            numImporte.Value = 0m;

            lblMensaje.Text = "Partida agregada: " + partida.Codigo + " - " + partida.Nombre
                + " (" + (partida.EsHaber ? EtiquetaCredito : EtiquetaDebito) + ").";
        }

        private void btnQuitarPartida_Click(object sender, EventArgs e)
        {
            int indice = dgvPartidas.CurrentCell == null ? -1 : dgvPartidas.CurrentCell.RowIndex;

            if (indice < 0 || indice >= partidas.Count)
            {
                lblMensaje.Text = "Seleccione la partida que desea quitar.";
                return;
            }

            Partida eliminada = partidas[indice];
            partidas.RemoveAt(indice);
            RefrescarPartidas();

            lblMensaje.Text = "Partida eliminada: " + eliminada.Codigo + " - " + eliminada.Nombre + ".";
        }

        private void btnRegistrarAsiento_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = (int)numNumeroAsiento.Value;
                string referencia = txtReferencia.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();

                if (numero <= 0)
                {
                    lblMensaje.Text = "Indique el número de asiento.";
                    numNumeroAsiento.Focus();
                    return;
                }
                if (referencia.Length == 0)
                {
                    lblMensaje.Text = "Escriba la referencia o factura del asiento.";
                    txtReferencia.Focus();
                    return;
                }
                if (descripcion.Length == 0)
                {
                    lblMensaje.Text = "Escriba la descripción del asiento.";
                    txtDescripcion.Focus();
                    return;
                }
                if (partidas.Count < 2)
                {
                    lblMensaje.Text = "El asiento debe tener al menos dos partidas.";
                    return;
                }
                if (ExisteNumeroAsiento(numero))
                {
                    lblMensaje.Text = "Ya existe un asiento con el número " + numero + ".";
                    numNumeroAsiento.Focus();
                    return;
                }

                decimal totalDebe = 0m;
                decimal totalHaber = 0m;
                foreach (Partida partida in partidas)
                {
                    if (partida.EsHaber) totalHaber += partida.Importe;
                    else totalDebe += partida.Importe;
                }

                if (totalDebe != totalHaber)
                {
                    lblMensaje.Text = "El asiento no cuadra: la diferencia entre debe y haber es "
                        + (totalDebe - totalHaber).ToString("N2") + ".";
                    return;
                }

                var nodoPartidas = new JsonArray();
                foreach (Partida partida in partidas)
                {
                    nodoPartidas.Add(new JsonObject
                    {
                        ["cuenta"] = partida.Codigo,
                        ["nombre_cuenta"] = partida.Nombre,
                        ["naturaleza"] = partida.Naturaleza,
                        ["debe"] = partida.EsHaber ? 0m : partida.Importe,
                        ["haber"] = partida.EsHaber ? partida.Importe : 0m
                    });
                }

                var nodoAsiento = new JsonObject
                {
                    ["numero_asiento"] = numero,
                    ["fecha"] = dtpFecha.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                    ["referencia"] = referencia,
                    ["descripcion"] = descripcion,
                    ["partidas"] = nodoPartidas,
                    ["total_debe"] = totalDebe,
                    ["total_haber"] = totalHaber
                };

                asientos.Add(nodoAsiento);
                GuardarOperaciones();
                ActualizarSaldosCuentas();
                ActualizarHistorial();

                lblMensaje.Text = "Asiento N° " + numero + " registrado correctamente en operaciones.json.";
                PrepararNuevoAsiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el asiento: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteNumeroAsiento(int numero)
        {
            if (asientos == null) return false;

            foreach (JsonNode nodo in asientos)
            {
                if (nodo is JsonObject asiento && LeerEntero(asiento, "numero_asiento") == numero)
                    return true;
            }
            return false;
        }

        private int SiguienteNumeroAsiento()
        {
            int maximo = 0;
            if (asientos == null) return 1;

            foreach (JsonNode nodo in asientos)
            {
                if (!(nodo is JsonObject asiento)) continue;

                int numero = LeerEntero(asiento, "numero_asiento");
                if (numero > maximo) maximo = numero;
            }
            return maximo + 1;
        }

        private void ActualizarSaldosCuentas()
        {
            if (raizCuentas == null) return;

            foreach (Partida partida in partidas)
            {
                JsonObject cuenta = BuscarCuentaJson(partida.Codigo);
                if (cuenta == null) continue;

                decimal saldo = LeerDecimal(cuenta, "saldo");

                if (partida.Naturaleza == NaturalezaCredito)
                    saldo += partida.EsHaber ? partida.Importe : -partida.Importe;
                else
                    saldo += partida.EsHaber ? -partida.Importe : partida.Importe;

                cuenta["saldo"] = saldo;
            }

            GuardarCuentas();
        }

        private void ActualizarHistorial()
        {
            dgvAsientos.Rows.Clear();
            if (asientos == null) return;

            var lista = new List<JsonObject>();
            foreach (JsonNode nodo in asientos)
            {
                if (nodo is JsonObject asiento) lista.Add(asiento);
            }

            lista.Sort((a, b) => LeerEntero(a, "numero_asiento").CompareTo(LeerEntero(b, "numero_asiento")));

            foreach (JsonObject asiento in lista)
            {
                dgvAsientos.Rows.Add(
                    LeerEntero(asiento, "numero_asiento"),
                    LeerFecha(asiento, "fecha"),
                    LeerTexto(asiento, "referencia"),
                    LeerTexto(asiento, "descripcion"),
                    LeerDecimal(asiento, "total_debe"),
                    LeerDecimal(asiento, "total_haber"));
            }
        }

        private void btnNuevoAsiento_Click(object sender, EventArgs e)
        {
            PrepararNuevoAsiento();
            lblMensaje.Text = "Nuevo asiento en preparación.";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarOperaciones();
            lblMensaje.Text = "Historial actualizado desde operaciones.json.";
        }

        private void PrepararNuevoAsiento()
        {
            partidas.Clear();
            RefrescarPartidas();

            txtReferencia.Clear();
            txtDescripcion.Clear();
            numNumeroAsiento.Value = Math.Min(SiguienteNumeroAsiento(), (int)numNumeroAsiento.Maximum);
            dtpFecha.Value = DateTime.Today;
        }
    }
}
