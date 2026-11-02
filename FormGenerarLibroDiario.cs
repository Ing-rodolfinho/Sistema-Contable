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
    public partial class FormGenerarLibroDiario : FormBase
    {
        private readonly string rutaOperaciones = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "operaciones.json");
        private readonly string rutaOperacionesProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "operaciones.json"));

        private JsonObject raizOperaciones;
        private JsonArray asientos;

        public FormGenerarLibroDiario()
        {
            InitializeComponent();
        }

        private FlowLayoutPanel barraFiltros;
        private FlowLayoutPanel barraTotales;

        protected override void OnPrepararContenido()
        {
            ConstruirBarraFiltros();
            ConstruirBarraTotales();
        }

        private void ConstruirBarraFiltros()
        {
            if (barraFiltros != null) return;

            barraFiltros = new FlowLayoutPanel();
            barraFiltros.Dock = DockStyle.Bottom;
            barraFiltros.Height = 30;
            barraFiltros.WrapContents = false;
            barraFiltros.FlowDirection = FlowDirection.LeftToRight;
            barraFiltros.BackColor = Color.Transparent;
            barraFiltros.Padding = new Padding(13, 0, 0, 0);

            panelSuperior.SuspendLayout();
            panelSuperior.Controls.Remove(lblDesde);
            panelSuperior.Controls.Remove(dtpDesde);
            panelSuperior.Controls.Remove(lblHasta);
            panelSuperior.Controls.Remove(dtpHasta);
            panelSuperior.Controls.Remove(btnGenerar);

            lblDesde.Margin = new Padding(0, 6, 6, 0);
            lblHasta.Margin = new Padding(0, 6, 6, 0);
            dtpDesde.Width = 124;
            dtpHasta.Width = 124;
            dtpDesde.Margin = new Padding(0, 3, 16, 0);
            dtpHasta.Margin = new Padding(0, 3, 16, 0);
            btnGenerar.Margin = new Padding(0, 3, 0, 0);

            barraFiltros.Controls.Add(lblDesde);
            barraFiltros.Controls.Add(dtpDesde);
            barraFiltros.Controls.Add(lblHasta);
            barraFiltros.Controls.Add(dtpHasta);
            barraFiltros.Controls.Add(btnGenerar);
            panelSuperior.Controls.Add(barraFiltros);
            panelSuperior.ResumeLayout(true);
        }

        private void ConstruirBarraTotales()
        {
            if (barraTotales != null) return;

            barraTotales = new FlowLayoutPanel();
            barraTotales.Dock = DockStyle.Right;
            barraTotales.AutoSize = true;
            barraTotales.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            barraTotales.WrapContents = false;
            barraTotales.FlowDirection = FlowDirection.LeftToRight;
            barraTotales.BackColor = Color.Transparent;
            barraTotales.Padding = new Padding(0, 10, 18, 0);

            panelTotales.SuspendLayout();
            panelTotales.Controls.Remove(lblTotalDebe);
            panelTotales.Controls.Remove(lblTotalHaber);
            panelTotales.Controls.Remove(lblDiferencia);

            lblTotalDebe.Anchor = AnchorStyles.None;
            lblTotalHaber.Anchor = AnchorStyles.None;
            lblDiferencia.Anchor = AnchorStyles.None;
            lblTotalDebe.Margin = new Padding(0, 0, 18, 0);
            lblTotalHaber.Margin = new Padding(0, 0, 18, 0);
            lblDiferencia.Margin = new Padding(0);

            barraTotales.Controls.Add(lblTotalDebe);
            barraTotales.Controls.Add(lblTotalHaber);
            barraTotales.Controls.Add(lblDiferencia);
            panelTotales.Controls.Add(barraTotales);
            panelTotales.ResumeLayout(true);
        }

        private void FormGenerarLibroDiario_Load(object sender, EventArgs e)
        {
            InicializarFechas();
            CargarYMostrarLibroDiario();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CargarYMostrarLibroDiario();
        }

        private string ResolverRuta(string rutaPrincipal, string rutaProyecto)
        {
            if (File.Exists(rutaPrincipal)) return rutaPrincipal;
            if (File.Exists(rutaProyecto)) return rutaProyecto;
            return rutaPrincipal;
        }

        private static string LeerTexto(JsonObject objeto, string clave)
        {
            if (!(objeto?[clave] is JsonValue valor)) return string.Empty;
            return valor.TryGetValue(out string texto) ? (texto ?? string.Empty) : string.Empty;
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

        private static DateTime? LeerFechaAsiento(JsonObject asiento)
        {
            string texto = LeerTexto(asiento, "fecha");
            if (string.IsNullOrEmpty(texto)) return null;

            if (DateTime.TryParseExact(texto, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaExacta))
                return fechaExacta.Date;

            if (DateTime.TryParse(texto, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaParseada))
                return fechaParseada.Date;

            if (DateTime.TryParse(texto, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime fechaParseadaLocal))
                return fechaParseadaLocal.Date;

            return null;
        }

        private static string FormatearFecha(DateTime? fecha)
        {
            if (!fecha.HasValue) return string.Empty;
            return fecha.Value.ToString("dd/MM/yyyy");
        }

        private void InicializarFechas()
        {
            try
            {
                CargarAsientos();

                if (asientos == null || asientos.Count == 0)
                {
                    dtpDesde.Value = DateTime.Today;
                    dtpHasta.Value = DateTime.Today;
                    return;
                }

                DateTime? fechaMin = null;
                DateTime? fechaMax = null;

                foreach (JsonNode nodo in asientos)
                {
                    if (!(nodo is JsonObject asiento)) continue;
                    DateTime? fecha = LeerFechaAsiento(asiento);
                    if (!fecha.HasValue) continue;

                    if (!fechaMin.HasValue || fecha.Value < fechaMin.Value)
                        fechaMin = fecha.Value;
                    if (!fechaMax.HasValue || fecha.Value > fechaMax.Value)
                        fechaMax = fecha.Value;
                }

                dtpDesde.Value = fechaMin ?? DateTime.Today;
                dtpHasta.Value = fechaMax ?? DateTime.Today;
            }
            catch
            {
                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today;
            }
        }

        private void CargarAsientos()
        {
            try
            {
                raizOperaciones = null;
                asientos = null;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer operaciones.json: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                asientos = new JsonArray();
                raizOperaciones = new JsonObject();
            }
        }

        private void CargarYMostrarLibroDiario()
        {
            try
            {
                CargarAsientos();
                dgvLibroDiario.Rows.Clear();

                if (asientos == null || asientos.Count == 0)
                {
                    ActualizarTotales(0m, 0m);
                    return;
                }

                DateTime fechaDesde = dtpDesde.Value.Date;
                DateTime fechaHasta = dtpHasta.Value.Date;

                var listaAsientos = new List<JsonObject>();
                foreach (JsonNode nodo in asientos)
                {
                    if (!(nodo is JsonObject asiento)) continue;

                    DateTime? fechaAsiento = LeerFechaAsiento(asiento);
                    if (!fechaAsiento.HasValue) continue;

                    if (fechaAsiento.Value < fechaDesde || fechaAsiento.Value > fechaHasta)
                        continue;

                    listaAsientos.Add(asiento);
                }

                listaAsientos.Sort((a, b) =>
                {
                    DateTime? fa = LeerFechaAsiento(a);
                    DateTime? fb = LeerFechaAsiento(b);
                    int cmpFecha = Nullable.Compare(fa, fb);
                    if (cmpFecha != 0) return cmpFecha;
                    return LeerEntero(a, "numero_asiento").CompareTo(LeerEntero(b, "numero_asiento"));
                });

                decimal totalDebe = 0m;
                decimal totalHaber = 0m;

                foreach (JsonObject asiento in listaAsientos)
                {
                    string fecha = FormatearFecha(LeerFechaAsiento(asiento));
                    int numeroAsiento = LeerEntero(asiento, "numero_asiento");
                    string referencia = LeerTexto(asiento, "referencia");
                    string descripcion = LeerTexto(asiento, "descripcion");

                    if (!(asiento["partidas"] is JsonArray partidasArray)) continue;

                    foreach (JsonNode partidaNodo in partidasArray)
                    {
                        if (!(partidaNodo is JsonObject partida)) continue;

                        string codigo = LeerTexto(partida, "cuenta");
                        string nombreCuenta = LeerTexto(partida, "nombre_cuenta");
                        decimal debe = LeerDecimal(partida, "debe");
                        decimal haber = LeerDecimal(partida, "haber");

                        totalDebe += debe;
                        totalHaber += haber;

                        string debeStr = debe == 0m ? string.Empty : debe.ToString("N2", CultureInfo.CurrentCulture);
                        string haberStr = haber == 0m ? string.Empty : haber.ToString("N2", CultureInfo.CurrentCulture);

                        dgvLibroDiario.Rows.Add(
                            fecha,
                            numeroAsiento.ToString(),
                            codigo,
                            nombreCuenta,
                            referencia,
                            descripcion,
                            debeStr,
                            haberStr);
                    }
                }

                ActualizarTotales(totalDebe, totalHaber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el Libro Diario: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTotales(decimal totalDebe, decimal totalHaber)
        {
            decimal diferencia = totalDebe - totalHaber;

            lblTotalDebe.Text = "Total Debe: " + totalDebe.ToString("N2", CultureInfo.CurrentCulture);
            lblTotalHaber.Text = "Total Haber: " + totalHaber.ToString("N2", CultureInfo.CurrentCulture);
            lblDiferencia.Text = "Diferencia: " + diferencia.ToString("N2", CultureInfo.CurrentCulture);
            lblDiferencia.ForeColor = Math.Abs(diferencia) < 0.0001m ? Color.SeaGreen : Color.Firebrick;
        }
    }
}
