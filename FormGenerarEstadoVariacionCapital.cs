using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGenerarEstadoVariacionCapital : FormBase
    {
        private readonly List<CuentaContable> cuentas = new List<CuentaContable>();
        private readonly List<AsientoContable> asientos = new List<AsientoContable>();

        private bool cargando;

        public FormGenerarEstadoVariacionCapital()
        {
            InitializeComponent();
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

        private void CalcularMovimientos(CuentaContable cuenta, DateTime desde, DateTime hasta,
            out decimal aumentos, out decimal disminuciones)
        {
            aumentos = 0m;
            disminuciones = 0m;

            foreach (AsientoContable asiento in asientos)
            {
                if (!asiento.Fecha.HasValue) continue;
                if (asiento.Fecha.Value.Date < desde || asiento.Fecha.Value.Date > hasta) continue;

                foreach (PartidaContable partida in asiento.Partidas)
                {
                    if (!string.Equals(partida.Cuenta, cuenta.Codigo, StringComparison.OrdinalIgnoreCase))
                        continue;

                    if (cuenta.EsDeudora)
                    {
                        aumentos += partida.Debe;
                        disminuciones += partida.Haber;
                    }
                    else
                    {
                        aumentos += partida.Haber;
                        disminuciones += partida.Debe;
                    }
                }
            }
        }

        private void Generar()
        {
            if (cargando || dgvVariacion == null) return;

            dgvVariacion.Rows.Clear();

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "La fecha inicial no puede ser mayor que la fecha final.";
                return;
            }

            Dictionary<string, CuentaContable> mapa = DatosContables.IndexarCuentas(cuentas);
            List<CuentaContable> capital = new List<CuentaContable>();
            foreach (CuentaContable cuenta in cuentas)
            {
                if (cuenta.EsPatrimonio) capital.Add(cuenta);
            }
            capital.Sort((a, b) => string.Compare(a.Codigo, b.Codigo, StringComparison.OrdinalIgnoreCase));

            decimal totalInicial = 0m;
            decimal totalAumentos = 0m;
            decimal totalDisminuciones = 0m;
            decimal totalFinal = 0m;

            int fila = dgvVariacion.Rows.Add("CAPITAL / PATRIMONIO", string.Empty, string.Empty,
                string.Empty, string.Empty);
            UiContable.EstilizarFila(dgvVariacion.Rows[fila], true, UiContable.EncabezadoTabla);

            bool hayCuentas = false;

            foreach (CuentaContable cuenta in capital)
            {
                decimal saldoInicial = DatosContables.SaldoEnFecha(cuenta, asientos, desde.AddDays(-1));
                decimal saldoFinal = DatosContables.SaldoEnFecha(cuenta, asientos, hasta);

                decimal aumentos;
                decimal disminuciones;
                CalcularMovimientos(cuenta, desde, hasta, out aumentos, out disminuciones);

                if (saldoInicial == 0m && aumentos == 0m && disminuciones == 0m && saldoFinal == 0m)
                    continue;

                hayCuentas = true;
                totalInicial += saldoInicial;
                totalAumentos += aumentos;
                totalDisminuciones += disminuciones;
                totalFinal += saldoFinal;

                dgvVariacion.Rows.Add(cuenta.Codigo + " - " + cuenta.Nombre,
                    DatosContables.FormatearMonto(saldoInicial),
                    DatosContables.FormatearMonto(aumentos),
                    DatosContables.FormatearMonto(disminuciones),
                    DatosContables.FormatearMonto(saldoFinal));
            }

            if (!hayCuentas)
            {
                dgvVariacion.Rows.Add("Sin cuentas de capital con movimientos en el período.",
                    string.Empty, string.Empty, string.Empty, string.Empty);
            }

            decimal resultadoAnterior = DatosContables.CalcularResultadoAcumulado(
                asientos, mapa, desde.AddDays(-1));
            decimal resultadoPeriodo = DatosContables.CalcularResultadoEnRango(
                asientos, mapa, desde, hasta);

            if (resultadoAnterior != 0m)
            {
                dgvVariacion.Rows.Add("Resultados acumulados de períodos anteriores",
                    DatosContables.FormatearMonto(resultadoAnterior),
                    DatosContables.FormatearMonto(0m),
                    DatosContables.FormatearMonto(0m),
                    DatosContables.FormatearMonto(resultadoAnterior));
                totalInicial += resultadoAnterior;
                totalFinal += resultadoAnterior;
            }

            if (resultadoPeriodo != 0m)
            {
                decimal aumentosPeriodo = resultadoPeriodo > 0m ? resultadoPeriodo : 0m;
                decimal disminucionesPeriodo = resultadoPeriodo < 0m ? -resultadoPeriodo : 0m;

                dgvVariacion.Rows.Add("Resultado del período",
                    DatosContables.FormatearMonto(0m),
                    DatosContables.FormatearMonto(aumentosPeriodo),
                    DatosContables.FormatearMonto(disminucionesPeriodo),
                    DatosContables.FormatearMonto(resultadoPeriodo));

                totalAumentos += aumentosPeriodo;
                totalDisminuciones += disminucionesPeriodo;
                totalFinal += resultadoPeriodo;
            }

            fila = dgvVariacion.Rows.Add("TOTAL CAPITAL / PATRIMONIO",
                DatosContables.FormatearMonto(totalInicial),
                DatosContables.FormatearMonto(totalAumentos),
                DatosContables.FormatearMonto(totalDisminuciones),
                DatosContables.FormatearMonto(totalFinal));
            UiContable.EstilizarFila(dgvVariacion.Rows[fila], true, UiContable.RosaSuave);

            dgvVariacion.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            decimal patrimonioBalance = 0m;
            foreach (CuentaContable cuenta in capital)
                patrimonioBalance += DatosContables.SaldoEnFecha(cuenta, asientos, hasta);
            patrimonioBalance += DatosContables.CalcularResultadoAcumulado(asientos, mapa, hasta);

            decimal diferencia = totalFinal - patrimonioBalance;

            fila = dgvVariacion.Rows.Add("Patrimonio total según Balance General",
                string.Empty, string.Empty, string.Empty,
                DatosContables.FormatearMonto(patrimonioBalance));
            UiContable.EstilizarFila(dgvVariacion.Rows[fila], true, UiContable.EncabezadoTabla);

            fila = dgvVariacion.Rows.Add("DIFERENCIA DE CONCILIACIÓN",
                string.Empty, string.Empty, string.Empty,
                DatosContables.FormatearMonto(diferencia));
            UiContable.EstilizarFila(dgvVariacion.Rows[fila], true,
                Math.Abs(diferencia) < 0.005m
                    ? Color.FromArgb(232, 245, 233)
                    : Color.FromArgb(255, 235, 238));
            dgvVariacion.Rows[fila].Cells[4].Style.ForeColor =
                Math.Abs(diferencia) < 0.005m ? UiContable.Positivo : UiContable.Negativo;

            string mensaje = "Período: " + desde.ToString("dd/MM/yyyy") + " al " + hasta.ToString("dd/MM/yyyy")
                + "   |   Saldo inicial: " + DatosContables.FormatearMonto(totalInicial)
                + "   |   Aumentos: " + DatosContables.FormatearMonto(totalAumentos)
                + "   |   Disminuciones: " + DatosContables.FormatearMonto(totalDisminuciones)
                + "   |   Saldo final: " + DatosContables.FormatearMonto(totalFinal);

            if (Math.Abs(diferencia) < 0.005m)
            {
                lblEstado.ForeColor = UiContable.Positivo;
                lblEstado.Text = mensaje + "   |   Conciliado con el Balance General.";
            }
            else
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = mensaje + "   |   Revise los saldos y el resultado del período.";
            }
        }
    }
}
