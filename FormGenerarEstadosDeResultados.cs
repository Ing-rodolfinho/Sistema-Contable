using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGenerarEstadosDeResultados : FormBase
    {
        private readonly List<CuentaContable> cuentas = new List<CuentaContable>();
        private readonly List<AsientoContable> asientos = new List<AsientoContable>();

        private bool cargando;

        public FormGenerarEstadosDeResultados()
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

        private List<CuentaContable> ObtenerCuentasOrdenadas()
        {
            List<CuentaContable> ordenadas = new List<CuentaContable>(cuentas);
            ordenadas.Sort((a, b) => string.Compare(a.Codigo, b.Codigo, StringComparison.OrdinalIgnoreCase));
            return ordenadas;
        }

        private void Generar()
        {
            if (cargando || dgvResultados == null) return;

            dgvResultados.Rows.Clear();

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "La fecha inicial no puede ser mayor que la fecha final.";
                return;
            }

            List<CuentaContable> ordenadas = ObtenerCuentasOrdenadas();
            List<CuentaContable> ingresos = new List<CuentaContable>();
            List<CuentaContable> costos = new List<CuentaContable>();
            List<CuentaContable> gastos = new List<CuentaContable>();
            var importes = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);

            foreach (CuentaContable cuenta in ordenadas)
            {
                if (!cuenta.EsIngreso && !cuenta.EsCosto && !cuenta.EsGasto) continue;

                decimal efecto = DatosContables.EfectoEnRango(cuenta, asientos, desde, hasta);
                if (efecto == 0m) continue;

                importes[cuenta.Codigo] = efecto;
                if (cuenta.EsIngreso) ingresos.Add(cuenta);
                else if (cuenta.EsCosto) costos.Add(cuenta);
                else gastos.Add(cuenta);
            }

            decimal totalIngresos = 0m;
            decimal totalCostos = 0m;
            decimal totalGastos = 0m;

            int fila = dgvResultados.Rows.Add("INGRESOS", string.Empty);
            UiContable.EstilizarFila(dgvResultados.Rows[fila], true, UiContable.EncabezadoTabla);

            if (ingresos.Count == 0)
            {
                dgvResultados.Rows.Add("Sin ingresos registrados en el período.", string.Empty);
            }
            else
            {
                foreach (CuentaContable cuenta in ingresos)
                {
                    decimal importe = importes[cuenta.Codigo];
                    totalIngresos += importe;
                    dgvResultados.Rows.Add(cuenta.Codigo + " - " + cuenta.Nombre,
                        DatosContables.FormatearMonto(importe));
                }
            }

            fila = dgvResultados.Rows.Add("TOTAL INGRESOS", DatosContables.FormatearMonto(totalIngresos));
            UiContable.EstilizarFila(dgvResultados.Rows[fila], true, UiContable.RosaSuave);

            dgvResultados.Rows.Add(string.Empty, string.Empty);

            fila = dgvResultados.Rows.Add("COSTOS", string.Empty);
            UiContable.EstilizarFila(dgvResultados.Rows[fila], true, UiContable.EncabezadoTabla);

            if (costos.Count == 0)
            {
                dgvResultados.Rows.Add("Sin costos registrados en el período.", string.Empty);
            }
            else
            {
                foreach (CuentaContable cuenta in costos)
                {
                    decimal importe = importes[cuenta.Codigo];
                    totalCostos += importe;
                    dgvResultados.Rows.Add(cuenta.Codigo + " - " + cuenta.Nombre,
                        DatosContables.FormatearMonto(importe));
                }
            }

            fila = dgvResultados.Rows.Add("TOTAL COSTOS", DatosContables.FormatearMonto(totalCostos));
            UiContable.EstilizarFila(dgvResultados.Rows[fila], true, UiContable.RosaSuave);

            dgvResultados.Rows.Add(string.Empty, string.Empty);

            fila = dgvResultados.Rows.Add("GASTOS", string.Empty);
            UiContable.EstilizarFila(dgvResultados.Rows[fila], true, UiContable.EncabezadoTabla);

            if (gastos.Count == 0)
            {
                dgvResultados.Rows.Add("Sin gastos registrados en el período.", string.Empty);
            }
            else
            {
                foreach (CuentaContable cuenta in gastos)
                {
                    decimal importe = importes[cuenta.Codigo];
                    totalGastos += importe;
                    dgvResultados.Rows.Add(cuenta.Codigo + " - " + cuenta.Nombre,
                        DatosContables.FormatearMonto(importe));
                }
            }

            fila = dgvResultados.Rows.Add("TOTAL GASTOS", DatosContables.FormatearMonto(totalGastos));
            UiContable.EstilizarFila(dgvResultados.Rows[fila], true, UiContable.RosaSuave);

            dgvResultados.Rows.Add(string.Empty, string.Empty);

            decimal resultado = totalIngresos - totalCostos - totalGastos;
            bool utilidad = resultado >= 0m;
            string etiquetaResultado = utilidad ? "UTILIDAD DEL EJERCICIO" : "PÉRDIDA DEL EJERCICIO";

            fila = dgvResultados.Rows.Add(etiquetaResultado, DatosContables.FormatearMonto(Math.Abs(resultado)));
            UiContable.EstilizarFila(dgvResultados.Rows[fila], true,
                utilidad ? Color.FromArgb(232, 245, 233) : Color.FromArgb(255, 235, 238));
            dgvResultados.Rows[fila].Cells[0].Style.ForeColor = utilidad ? UiContable.Positivo : UiContable.Negativo;
            dgvResultados.Rows[fila].Cells[1].Style.ForeColor = utilidad ? UiContable.Positivo : UiContable.Negativo;

            string mensaje = "Período: " + desde.ToString("dd/MM/yyyy") + " al " + hasta.ToString("dd/MM/yyyy")
                + "   |   Ingresos: " + DatosContables.FormatearMonto(totalIngresos)
                + "   |   Costos: " + DatosContables.FormatearMonto(totalCostos)
                + "   |   Gastos: " + DatosContables.FormatearMonto(totalGastos)
                + "   |   Resultado: " + DatosContables.FormatearMonto(resultado);

            lblEstado.ForeColor = utilidad ? UiContable.Positivo : UiContable.Negativo;
            lblEstado.Text = mensaje;
        }
    }
}
