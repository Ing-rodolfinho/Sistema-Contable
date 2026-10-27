using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormConsultarCuentasT : FormBase
    {
        private const string NaturalezaDebito = "debito";
        private const string NaturalezaCredito = "credito";
        private const string EtiquetaDebito = "Débito";
        private const string EtiquetaCredito = "Crédito";
        private const string EtiquetaActiva = "Activa";
        private const string EtiquetaInactiva = "Inactiva";
        private const string EtiquetaSaldoAnterior = "SALDO ANTERIOR";

        private readonly string rutaCuentas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cuentas.json");
        private readonly string rutaCuentasProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Cuentas.json"));
        private readonly string rutaOperaciones = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "operaciones.json");
        private readonly string rutaOperacionesProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "operaciones.json"));

        private readonly List<CuentaListaItem> cuentasLista = new List<CuentaListaItem>();
        private readonly List<CuentaItem> cuentasMapa = new List<CuentaItem>();
        private JsonObject raizCuentas;
        private JsonObject raizOperaciones;
        private JsonArray asientos;
        private bool cargandoFiltros;

        private class CuentaListaItem
        {
            public string Codigo;
            public string Nombre;
            public string Tipo;
            public string Naturaleza;
            public string Estado;
            public string NaturalezaClave;
        }

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

        private class MovimientoCuentaT
        {
            public DateTime? Fecha;
            public string FechaTexto;
            public int NumeroAsiento;
            public string Referencia;
            public string Descripcion;
            public decimal Debe;
            public decimal Haber;
        }

        public FormConsultarCuentasT()
        {
            InitializeComponent();
        }

        private void FormConsultarCuentasT_Load(object sender, EventArgs e)
        {
            if (dgvCuentasLista != null)
                dgvCuentasLista.CellDoubleClick += dgvCuentasLista_CellDoubleClick;

            CargarDatos();
        }

        private void dgvCuentasLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvCuentasLista.Rows.Count) return;

            string codigo = Convert.ToString(dgvCuentasLista.Rows[e.RowIndex].Cells[0].Value);
            if (string.IsNullOrWhiteSpace(codigo)) return;

            txtCodigoCuenta.Text = codigo;
            ConsultarCuentaT();
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

        private static bool TryParseFecha(string texto, out DateTime fecha)
        {
            fecha = DateTime.MinValue;
            if (string.IsNullOrWhiteSpace(texto)) return false;

            if (DateTime.TryParseExact(texto.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out fecha))
                return true;

            return DateTime.TryParse(texto, CultureInfo.CurrentCulture, DateTimeStyles.None, out fecha);
        }

        private static string NombreBonito(string clave)
        {
            if (string.IsNullOrWhiteSpace(clave)) return clave ?? "";
            return string.Join(" ", clave.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => char.ToUpperInvariant(p[0]) + p.Substring(1).ToLowerInvariant()));
        }

        private void CargarDatos()
        {
            try
            {
                CargarCuentas();
                CargarOperaciones();
                EstablecerRangoFechas();
                LimpiarConsulta();
                if (lblMensaje != null)
                    lblMensaje.Text = "Ingrese el código de la cuenta en el apartado Cuenta T.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                cuentasLista.Clear();
                cuentasMapa.Clear();

                if (raizCuentas?["catalogo_cuentas"] is JsonObject catalogo)
                {
                    foreach (KeyValuePair<string, JsonNode> tipo in catalogo)
                    {
                        string nombreTipo = NombreBonito(tipo.Key);
                        if (!(tipo.Value is JsonObject grupos)) continue;

                        foreach (KeyValuePair<string, JsonNode> grupo in grupos)
                        {
                            if (!(grupo.Value is JsonArray lista)) continue;

                            foreach (JsonNode nodo in lista)
                            {
                                if (!(nodo is JsonObject cuentaObj)) continue;

                                string codigo = LeerTexto(cuentaObj, "codigo").Trim();
                                if (codigo.Length == 0) continue;

                                string naturaleza = LeerTexto(cuentaObj, "naturaleza").Trim().ToLowerInvariant();
                                if (naturaleza != NaturalezaCredito) naturaleza = NaturalezaDebito;

                                string nombreCuenta = LeerTexto(cuentaObj, "nombre").Trim();
                                string etiquetaNaturaleza = naturaleza == NaturalezaCredito ? EtiquetaCredito : EtiquetaDebito;
                                string estado = LeerTexto(cuentaObj, "estado").Trim().ToLowerInvariant();

                                cuentasLista.Add(new CuentaListaItem
                                {
                                    Codigo = codigo,
                                    Nombre = nombreCuenta,
                                    Tipo = nombreTipo,
                                    Naturaleza = etiquetaNaturaleza,
                                    NaturalezaClave = naturaleza,
                                    Estado = estado == "inactivo" ? EtiquetaInactiva : EtiquetaActiva
                                });

                                cuentasMapa.Add(new CuentaItem
                                {
                                    Codigo = codigo,
                                    Nombre = nombreCuenta,
                                    Naturaleza = naturaleza
                                });
                            }
                        }
                    }
                }

                if (dgvCuentasLista != null)
                {
                    dgvCuentasLista.Rows.Clear();
                    foreach (CuentaListaItem item in cuentasLista.OrderBy(c => c.Codigo))
                    {
                        dgvCuentasLista.Rows.Add(item.Codigo, item.Nombre, item.Tipo, item.Naturaleza, item.Estado);
                    }
                }

                ConfigurarAutocompletado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Cuentas.json: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarOperaciones()
        {
            try
            {
                raizOperaciones = null;
                asientos = null;

                string ruta = ResolverRuta(rutaOperaciones, rutaOperacionesProyecto);
                if (!File.Exists(ruta))
                {
                    asientos = new JsonArray();
                    return;
                }

                raizOperaciones = JsonNode.Parse(File.ReadAllText(ruta)) as JsonObject;
                asientos = raizOperaciones?["asientos"] as JsonArray ?? new JsonArray();
            }
            catch
            {
                raizOperaciones = null;
                asientos = new JsonArray();
            }
        }

        private void ConfigurarAutocompletado()
        {
            if (txtCodigoCuenta == null) return;

            var origen = new AutoCompleteStringCollection();
            foreach (CuentaListaItem item in cuentasLista.OrderBy(c => c.Codigo))
            {
                origen.Add(item.Codigo);

                string texto = item.Codigo + " - " + item.Nombre;
                if (origen.Contains(texto)) continue;
                origen.Add(texto);
            }

            txtCodigoCuenta.AutoCompleteCustomSource = origen;
            txtCodigoCuenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCodigoCuenta.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void EstablecerRangoFechas()
        {
            cargandoFiltros = true;
            try
            {
                DateTime minima = DateTime.MaxValue;
                DateTime maxima = DateTime.MinValue;

                if (asientos != null)
                {
                    foreach (JsonNode asientoNodo in asientos)
                    {
                        if (!(asientoNodo is JsonObject asientoObj)) continue;
                        if (!TryParseFecha(LeerTexto(asientoObj, "fecha"), out DateTime fecha)) continue;

                        if (fecha < minima) minima = fecha;
                        if (fecha > maxima) maxima = fecha;
                    }
                }

                if (minima == DateTime.MaxValue)
                {
                    minima = DateTime.Today.AddMonths(-1);
                    maxima = DateTime.Today;
                }

                if (maxima < minima) maxima = minima;

                if (dtpDesde != null)
                {
                    dtpDesde.Value = minima;
                    dtpDesde.Checked = true;
                }
                if (dtpHasta != null)
                {
                    dtpHasta.Value = maxima;
                    dtpHasta.Checked = true;
                }
            }
            finally
            {
                cargandoFiltros = false;
            }
        }

        private void LimpiarConsulta()
        {
            LimpiarResultados();
            if (txtCodigoCuenta != null) txtCodigoCuenta.Text = string.Empty;
        }

        private void LimpiarResultados()
        {
            if (dgvDebe != null) dgvDebe.Rows.Clear();
            if (dgvHaber != null) dgvHaber.Rows.Clear();
            if (lblTotalDebe != null) lblTotalDebe.Text = "Total Debe: $ 0.00";
            if (lblTotalHaber != null) lblTotalHaber.Text = "Total Haber: $ 0.00";
            if (lblResultado != null) lblResultado.Text = "SALDO FINAL: $ 0.00";
            if (lblCuentaTitulo != null) lblCuentaTitulo.Text = "Cuenta T";
        }

        private void dtpFiltro_ValueChanged(object sender, EventArgs e)
        {
            if (cargandoFiltros) return;
            ConsultarCuentaT();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarOperaciones();
            ConsultarCuentaT();
        }

        private void btnBuscarCuentaT_Click(object sender, EventArgs e)
        {
            CargarOperaciones();
            ConsultarCuentaT();
        }

        private List<MovimientoCuentaT> ObtenerMovimientos(string codigoCuenta)
        {
            List<MovimientoCuentaT> movimientos = new List<MovimientoCuentaT>();

            if (asientos == null) return movimientos;

            foreach (JsonNode asientoNodo in asientos)
            {
                if (!(asientoNodo is JsonObject asientoObj)) continue;

                int numeroAsiento = LeerEntero(asientoObj, "numero_asiento");
                string fechaTexto = LeerTexto(asientoObj, "fecha");
                string referencia = LeerTexto(asientoObj, "referencia");
                string descripcionAsiento = LeerTexto(asientoObj, "descripcion");

                DateTime? fecha = null;
                if (TryParseFecha(fechaTexto, out DateTime fechaParseada))
                    fecha = fechaParseada;

                if (!(asientoObj["partidas"] is JsonArray partidasArray)) continue;

                foreach (JsonNode partidaNodo in partidasArray)
                {
                    if (!(partidaNodo is JsonObject partidaObj)) continue;

                    string codigoPartida = LeerTexto(partidaObj, "cuenta").Trim();
                    if (!string.Equals(codigoPartida, codigoCuenta, StringComparison.OrdinalIgnoreCase))
                        continue;

                    movimientos.Add(new MovimientoCuentaT
                    {
                        Fecha = fecha,
                        FechaTexto = fecha.HasValue ? fecha.Value.ToString("dd/MM/yyyy") : fechaTexto,
                        NumeroAsiento = numeroAsiento,
                        Referencia = referencia,
                        Descripcion = descripcionAsiento,
                        Debe = LeerDecimal(partidaObj, "debe"),
                        Haber = LeerDecimal(partidaObj, "haber")
                    });
                }
            }

            return movimientos;
        }

        private void ConsultarCuentaT()
        {
            string codigoIngresado = txtCodigoCuenta != null ? txtCodigoCuenta.Text.Trim() : string.Empty;
            if (string.IsNullOrEmpty(codigoIngresado))
            {
                LimpiarResultados();
                if (lblMensaje != null)
                    lblMensaje.Text = "Ingrese el código de la cuenta en el apartado Cuenta T.";
                return;
            }

            // Si el usuario eligió una sugerencia "código - nombre", se toma solo el código.
            int separador = codigoIngresado.IndexOf(" - ", StringComparison.Ordinal);
            if (separador > 0) codigoIngresado = codigoIngresado.Substring(0, separador).Trim();

            CuentaItem cuentaSeleccionada = cuentasMapa.FirstOrDefault(c => string.Equals(c.Codigo, codigoIngresado, StringComparison.OrdinalIgnoreCase));
            if (cuentaSeleccionada == null)
            {
                LimpiarResultados();
                if (lblMensaje != null)
                    lblMensaje.Text = "No se encontró una cuenta con el código " + codigoIngresado + ".";
                return;
            }

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;
            if (desde > hasta)
            {
                if (lblMensaje != null)
                    lblMensaje.Text = "La fecha inicial no puede ser mayor que la fecha final.";
                return;
            }

            try
            {
                List<MovimientoCuentaT> todos = ObtenerMovimientos(cuentaSeleccionada.Codigo);

                decimal saldoActualDeudor = todos.Sum(m => m.Debe - m.Haber);

                decimal efectoEnRango = 0m;
                foreach (MovimientoCuentaT mov in todos)
                {
                    if (!mov.Fecha.HasValue) continue;
                    if (mov.Fecha.Value.Date >= desde)
                        efectoEnRango += mov.Debe - mov.Haber;
                }

                decimal saldoAnteriorDeudor = saldoActualDeudor - efectoEnRango;

                List<MovimientoCuentaT> movimientos = todos
                    .Where(m => m.Fecha.HasValue
                        && m.Fecha.Value.Date >= desde
                        && m.Fecha.Value.Date <= hasta)
                    .OrderBy(m => m.Fecha.Value)
                    .ThenBy(m => m.NumeroAsiento)
                    .ToList();

                if (dgvDebe != null) dgvDebe.Rows.Clear();
                if (dgvHaber != null) dgvHaber.Rows.Clear();

                decimal totalDebe = 0m;
                decimal totalHaber = 0m;

                AgregarSaldoAnterior(saldoAnteriorDeudor, ref totalDebe, ref totalHaber);

                foreach (MovimientoCuentaT mov in movimientos)
                {
                    if (mov.Debe > 0m)
                    {
                        if (dgvDebe != null)
                            dgvDebe.Rows.Add(mov.FechaTexto, mov.NumeroAsiento.ToString(),
                                mov.Referencia, mov.Descripcion, mov.Debe.ToString("N2"));
                        totalDebe += mov.Debe;
                    }

                    if (mov.Haber > 0m)
                    {
                        if (dgvHaber != null)
                            dgvHaber.Rows.Add(mov.FechaTexto, mov.NumeroAsiento.ToString(),
                                mov.Referencia, mov.Descripcion, mov.Haber.ToString("N2"));
                        totalHaber += mov.Haber;
                    }
                }

                if (lblCuentaTitulo != null)
                {
                    string etiquetaNaturaleza = cuentaSeleccionada.Naturaleza == NaturalezaCredito
                        ? EtiquetaCredito
                        : EtiquetaDebito;
                    lblCuentaTitulo.Text = "CUENTA T - " + cuentaSeleccionada.Codigo + " - " + cuentaSeleccionada.Nombre
                        + " (" + etiquetaNaturaleza + ")";
                }

                if (lblTotalDebe != null) lblTotalDebe.Text = "Total Debe: $ " + totalDebe.ToString("N2");
                if (lblTotalHaber != null) lblTotalHaber.Text = "Total Haber: $ " + totalHaber.ToString("N2");

                decimal saldoFinal = totalDebe - totalHaber;
                MostrarResultado(saldoFinal);

                if (lblMensaje != null)
                    lblMensaje.Text = "Período: " + desde.ToString("dd/MM/yyyy") + " al "
                        + hasta.ToString("dd/MM/yyyy") + " | Movimientos: " + movimientos.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la cuenta: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarSaldoAnterior(decimal saldoAnteriorDeudor, ref decimal totalDebe, ref decimal totalHaber)
        {
            if (saldoAnteriorDeudor > 0m)
            {
                if (dgvDebe != null)
                    dgvDebe.Rows.Add("", "", EtiquetaSaldoAnterior, "", saldoAnteriorDeudor.ToString("N2"));
                totalDebe += saldoAnteriorDeudor;
            }
            else if (saldoAnteriorDeudor < 0m)
            {
                decimal saldoAcreedor = -saldoAnteriorDeudor;
                if (dgvHaber != null)
                    dgvHaber.Rows.Add("", "", EtiquetaSaldoAnterior, "", saldoAcreedor.ToString("N2"));
                totalHaber += saldoAcreedor;
            }
        }

        private void MostrarResultado(decimal saldoFinalDeudor)
        {
            if (lblResultado == null) return;

            if (saldoFinalDeudor > 0m)
            {
                lblResultado.ForeColor = Color.SaddleBrown;
                lblResultado.Text = "SALDO FINAL DEUDOR: $ " + saldoFinalDeudor.ToString("N2");
            }
            else if (saldoFinalDeudor < 0m)
            {
                lblResultado.ForeColor = Color.SeaGreen;
                lblResultado.Text = "SALDO FINAL ACREEDOR: $ " + (-saldoFinalDeudor).ToString("N2");
            }
            else
            {
                lblResultado.ForeColor = Color.SaddleBrown;
                lblResultado.Text = "SALDO FINAL: $ 0.00";
            }
        }

        private void txtCodigoCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                CargarOperaciones();
                ConsultarCuentaT();
            }
        }
    }
}
