using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGenerarBalanzaDeComprobación : FormBase
    {
        private readonly List<CuentaContable> cuentas = new List<CuentaContable>();
        private readonly List<AsientoContable> asientos = new List<AsientoContable>();

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private DataGridView dgvBalanza;
        private Label lblEstado;
        private bool cargando;

        public FormGenerarBalanzaDeComprobación()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            Text = "Balanza de Comprobación";
            BackColor = UiContable.Fondo;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);

            TableLayoutPanel raiz = UiContable.CrearRaiz(this, "BALANZA DE COMPROBACIÓN");

            FlowLayoutPanel filtros = UiContable.CrearBarra();
            filtros.Controls.Add(UiContable.Etiqueta("Desde:"));
            dtpDesde = UiContable.CrearFecha(DateTime.Today.AddMonths(-1));
            dtpDesde.ValueChanged += Filtro_ValueChanged;
            filtros.Controls.Add(dtpDesde);

            filtros.Controls.Add(UiContable.Etiqueta("Hasta:"));
            dtpHasta = UiContable.CrearFecha(DateTime.Today);
            dtpHasta.ValueChanged += Filtro_ValueChanged;
            filtros.Controls.Add(dtpHasta);

            filtros.Controls.Add(UiContable.CrearBoton("Generar balanza", btnGenerar_Click));
            raiz.Controls.Add(filtros, 0, 1);

            dgvBalanza = UiContable.CrearGrid();
            dgvBalanza.Columns.AddRange(new DataGridViewColumn[]
            {
                UiContable.Columna("colCodigo", "Código", 55F, false),
                UiContable.Columna("colCuenta", "Cuenta", 175F, false),
                UiContable.Columna("colDebe", "Debe del período", 90F, true),
                UiContable.Columna("colHaber", "Haber del período", 90F, true),
                UiContable.Columna("colSaldoDeudor", "Saldo deudor", 95F, true),
                UiContable.Columna("colSaldoAcreedor", "Saldo acreedor", 95F, true)
            });
            UiContable.AgregarContenido(raiz, UiContable.CrearTarjeta(dgvBalanza));

            lblEstado = UiContable.CrearEstado();
            raiz.Controls.Add(lblEstado, 0, 3);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatos();
        }

        private void CargarDatos()
        {
            cargando = true;
            try
            {
                cuentas.Clear();
                asientos.Clear();

                string errorCuentas;
                cuentas.AddRange(DatosContables.CargarCuentas(out errorCuentas));
                if (!string.IsNullOrEmpty(errorCuentas))
                {
                    lblEstado.Text = errorCuentas;
                    lblEstado.ForeColor = UiContable.Negativo;
                    return;
                }

                string errorOperaciones;
                asientos.AddRange(DatosContables.CargarAsientos(out errorOperaciones));
                if (!string.IsNullOrEmpty(errorOperaciones))
                {
                    lblEstado.Text = errorOperaciones;
                    lblEstado.ForeColor = UiContable.Negativo;
                }

                ConfigurarRangoFechas();
            }
            finally
            {
                cargando = false;
            }

            Generar();
        }

        private void ConfigurarRangoFechas()
        {
            DateTime? minima = null;
            DateTime? maxima = null;

            foreach (AsientoContable asiento in asientos)
            {
                if (!asiento.Fecha.HasValue) continue;
                if (!minima.HasValue || asiento.Fecha.Value < minima.Value) minima = asiento.Fecha;
                if (!maxima.HasValue || asiento.Fecha.Value > maxima.Value) maxima = asiento.Fecha;
            }

            dtpDesde.Value = minima.HasValue ? minima.Value : DateTime.Today.AddMonths(-1);
            dtpHasta.Value = maxima.HasValue ? maxima.Value : DateTime.Today;
        }

        private void Filtro_ValueChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            Generar();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void Generar()
        {
            if (cargando || dgvBalanza == null) return;

            dgvBalanza.Rows.Clear();

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "La fecha inicial no puede ser mayor que la fecha final.";
                return;
            }

            List<AsientoContable> ordenados = DatosContables.OrdenarPorFecha(asientos).ToList();
            List<CuentaContable> cuentasOrdenadas = new List<CuentaContable>(cuentas);
            cuentasOrdenadas.Sort((a, b) => string.Compare(a.Codigo, b.Codigo, StringComparison.OrdinalIgnoreCase));

            decimal totalDebe = 0m;
            decimal totalHaber = 0m;
            decimal totalDeudor = 0m;
            decimal totalAcreedor = 0m;
            int cuentasIncluidas = 0;

            foreach (CuentaContable cuenta in cuentasOrdenadas)
            {
                decimal debe = 0m;
                decimal haber = 0m;

                foreach (AsientoContable asiento in ordenados)
                {
                    if (!asiento.Fecha.HasValue) continue;
                    if (asiento.Fecha.Value.Date < desde || asiento.Fecha.Value.Date > hasta) continue;

                    foreach (PartidaContable partida in asiento.Partidas)
                    {
                        if (!string.Equals(partida.Cuenta, cuenta.Codigo, StringComparison.OrdinalIgnoreCase))
                            continue;

                        debe += partida.Debe;
                        haber += partida.Haber;
                    }
                }

                decimal saldoNatural = DatosContables.SaldoEnFecha(cuenta, ordenados, hasta);
                if (debe == 0m && haber == 0m && saldoNatural == 0m) continue;

                decimal saldoDeudorSigno = DatosContables.SaldoDeudor(saldoNatural, cuenta);
                decimal saldoDeudor = saldoDeudorSigno > 0m ? saldoDeudorSigno : 0m;
                decimal saldoAcreedor = saldoDeudorSigno < 0m ? -saldoDeudorSigno : 0m;

                if (saldoDeudor > 0m)
                    dgvBalanza.Rows.Add(cuenta.Codigo, cuenta.Nombre,
                        DatosContables.MontoCelda(debe), DatosContables.MontoCelda(haber),
                        DatosContables.FormatearMonto(saldoDeudor), string.Empty);
                else
                    dgvBalanza.Rows.Add(cuenta.Codigo, cuenta.Nombre,
                        DatosContables.MontoCelda(debe), DatosContables.MontoCelda(haber),
                        string.Empty, DatosContables.FormatearMonto(saldoAcreedor));

                totalDebe += debe;
                totalHaber += haber;
                totalDeudor += saldoDeudor;
                totalAcreedor += saldoAcreedor;
                cuentasIncluidas++;
            }

            if (cuentasIncluidas == 0)
            {
                lblEstado.ForeColor = UiContable.Acento;
                lblEstado.Text = "No hay cuentas con movimientos ni saldo para el período seleccionado.";
                return;
            }

            int filaTotales = dgvBalanza.Rows.Add(
                string.Empty,
                "TOTALES",
                DatosContables.FormatearMonto(totalDebe),
                DatosContables.FormatearMonto(totalHaber),
                DatosContables.FormatearMonto(totalDeudor),
                DatosContables.FormatearMonto(totalAcreedor));
            UiContable.EstilizarFila(dgvBalanza.Rows[filaTotales], true, UiContable.RosaSuave);

            decimal diferenciaPeriodo = totalDebe - totalHaber;
            decimal diferenciaSaldos = totalDeudor - totalAcreedor;

            string mensaje = "Cuentas: " + cuentasIncluidas
                + "   |   Debe: " + DatosContables.FormatearMonto(totalDebe)
                + "   |   Haber: " + DatosContables.FormatearMonto(totalHaber)
                + "   |   Saldo deudor: " + DatosContables.FormatearMonto(totalDeudor)
                + "   |   Saldo acreedor: " + DatosContables.FormatearMonto(totalAcreedor);

            bool periodoCuadra = Math.Abs(diferenciaPeriodo) < 0.005m;
            bool saldosCuadran = Math.Abs(diferenciaSaldos) < 0.005m;

            if (periodoCuadra && saldosCuadran)
            {
                lblEstado.ForeColor = UiContable.Positivo;
                lblEstado.Text = mensaje + "   |   Balanza cuadrada.";
            }
            else
            {
                lblEstado.ForeColor = UiContable.Negativo;
                if (!periodoCuadra)
                    mensaje += "   |   Diferencia del período: " + DatosContables.FormatearMonto(diferenciaPeriodo);
                if (!saldosCuadran)
                    mensaje += "   |   Diferencia de saldos: " + DatosContables.FormatearMonto(diferenciaSaldos);
                lblEstado.Text = mensaje;
            }
        }
    }
}
