using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGenerarEstadoFlujoEfectivo : FormBase
    {
        private const string Operacion = "operacion";
        private const string Inversion = "inversion";
        private const string Financiamiento = "financiamiento";

        private readonly List<CuentaContable> cuentas = new List<CuentaContable>();
        private readonly List<AsientoContable> asientos = new List<AsientoContable>();

        private bool cargando;

        public FormGenerarEstadoFlujoEfectivo()
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

        private static string Clasificar(CuentaContable cuenta)
        {
            if (cuenta == null) return Operacion;

            if (cuenta.EsIngreso || cuenta.EsCosto || cuenta.EsGasto)
                return Operacion;

            if (DatosContables.EsActivoNoCorriente(cuenta))
                return Inversion;

            if (DatosContables.EsPasivoNoCorriente(cuenta) || cuenta.EsPatrimonio)
                return Financiamiento;

            return Operacion;
        }

        private static string NombreCategoria(string categoria)
        {
            switch (categoria)
            {
                case Inversion: return "ACTIVIDADES DE INVERSIÓN";
                case Financiamiento: return "ACTIVIDADES DE FINANCIAMIENTO";
                default: return "ACTIVIDADES DE OPERACIÓN";
            }
        }

        private static string TextoVacioCategoria(string categoria)
        {
            switch (categoria)
            {
                case Inversion: return "Sin movimientos de inversión en el período.";
                case Financiamiento: return "Sin movimientos de financiamiento en el período.";
                default: return "Sin movimientos de operación en el período.";
            }
        }

        private decimal SaldoEfectivo(DateTime fecha)
        {
            decimal total = 0m;
            foreach (CuentaContable cuenta in cuentas)
            {
                if (!DatosContables.EsCuentaEfectivo(cuenta)) continue;
                total += DatosContables.SaldoEnFecha(cuenta, asientos, fecha);
            }
            return total;
        }

        private void Generar()
        {
            if (cargando || dgvFlujo == null) return;

            dgvFlujo.Rows.Clear();

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "La fecha inicial no puede ser mayor que la fecha final.";
                return;
            }

            Dictionary<string, CuentaContable> mapa = DatosContables.IndexarCuentas(cuentas);

            var detalle = new Dictionary<string, SortedDictionary<string, decimal>>(
                StringComparer.OrdinalIgnoreCase);
            detalle[Operacion] = new SortedDictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
            detalle[Inversion] = new SortedDictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
            detalle[Financiamiento] = new SortedDictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);

            foreach (AsientoContable asiento in asientos)
            {
                if (!asiento.Fecha.HasValue) continue;
                if (asiento.Fecha.Value.Date < desde || asiento.Fecha.Value.Date > hasta) continue;

                bool tieneEfectivo = false;
                foreach (PartidaContable partida in asiento.Partidas)
                {
                    CuentaContable cuenta;
                    if (!mapa.TryGetValue(partida.Cuenta, out cuenta)) continue;
                    if (DatosContables.EsCuentaEfectivo(cuenta))
                    {
                        tieneEfectivo = true;
                        break;
                    }
                }

                if (!tieneEfectivo) continue;

                foreach (PartidaContable partida in asiento.Partidas)
                {
                    CuentaContable cuenta;
                    mapa.TryGetValue(partida.Cuenta, out cuenta);

                    if (cuenta != null && DatosContables.EsCuentaEfectivo(cuenta))
                        continue;

                    // El efecto sobre el efectivo es el inverso del movimiento
                    // de la contrapartida: un cargo (debe) consume efectivo.
                    decimal efecto = -(partida.Debe - partida.Haber);
                    if (efecto == 0m) continue;

                    string categoria = Clasificar(cuenta);
                    string etiqueta = cuenta != null
                        ? cuenta.Codigo + " - " + cuenta.Nombre
                        : partida.Cuenta + " - " + partida.NombreCuenta;

                    SortedDictionary<string, decimal> lineas = detalle[categoria];
                    decimal acumulado;
                    lineas.TryGetValue(etiqueta, out acumulado);
                    lineas[etiqueta] = acumulado + efecto;
                }
            }

            decimal totalOperacion = 0m;
            decimal totalInversion = 0m;
            decimal totalFinanciamiento = 0m;

            totalOperacion = AgregarCategoria(detalle[Operacion], Operacion);
            totalInversion = AgregarCategoria(detalle[Inversion], Inversion);
            totalFinanciamiento = AgregarCategoria(detalle[Financiamiento], Financiamiento);

            decimal variacionClasificada = totalOperacion + totalInversion + totalFinanciamiento;

            int fila = dgvFlujo.Rows.Add("VARIACIÓN NETA DEL EFECTIVO",
                DatosContables.FormatearMonto(variacionClasificada));
            UiContable.EstilizarFila(dgvFlujo.Rows[fila], true, UiContable.RosaSuave);

            dgvFlujo.Rows.Add(string.Empty, string.Empty);

            decimal saldoInicial = SaldoEfectivo(desde.AddDays(-1));
            decimal saldoFinal = SaldoEfectivo(hasta);
            decimal variacionReal = saldoFinal - saldoInicial;

            AgregarLinea("Efectivo y equivalentes al inicio del período",
                DatosContables.FormatearMonto(saldoInicial));
            AgregarLinea("Efectivo y equivalentes al final del período",
                DatosContables.FormatearMonto(saldoFinal));

            decimal diferencia = variacionClasificada - variacionReal;

            fila = dgvFlujo.Rows.Add("DIFERENCIA DE CONCILIACIÓN",
                DatosContables.FormatearMonto(diferencia));
            UiContable.EstilizarFila(dgvFlujo.Rows[fila], true,
                Math.Abs(diferencia) < 0.005m
                    ? Color.FromArgb(232, 245, 233)
                    : Color.FromArgb(255, 235, 238));
            dgvFlujo.Rows[fila].Cells[1].Style.ForeColor =
                Math.Abs(diferencia) < 0.005m ? UiContable.Positivo : UiContable.Negativo;

            string mensaje = "Período: " + desde.ToString("dd/MM/yyyy") + " al " + hasta.ToString("dd/MM/yyyy")
                + "   |   Operación: " + DatosContables.FormatearMonto(totalOperacion)
                + "   |   Inversión: " + DatosContables.FormatearMonto(totalInversion)
                + "   |   Financiamiento: " + DatosContables.FormatearMonto(totalFinanciamiento)
                + "   |   Variación neta: " + DatosContables.FormatearMonto(variacionReal);

            if (Math.Abs(diferencia) < 0.005m)
            {
                lblEstado.ForeColor = UiContable.Positivo;
                lblEstado.Text = mensaje + "   |   Flujo conciliado con el saldo de efectivo.";
            }
            else
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = mensaje + "   |   Revise los asientos sin contrapartida o descuadrados.";
            }
        }

        private decimal AgregarCategoria(SortedDictionary<string, decimal> lineas, string categoria)
        {
            int fila = dgvFlujo.Rows.Add(NombreCategoria(categoria), string.Empty);
            UiContable.EstilizarFila(dgvFlujo.Rows[fila], true, UiContable.EncabezadoTabla);

            decimal total = 0m;

            if (lineas.Count == 0)
            {
                dgvFlujo.Rows.Add(TextoVacioCategoria(categoria), string.Empty);
            }
            else
            {
                foreach (KeyValuePair<string, decimal> linea in lineas)
                {
                    total += linea.Value;
                    AgregarLinea(linea.Key, DatosContables.FormatearMonto(linea.Value));
                }
            }

            fila = dgvFlujo.Rows.Add("Subtotal " + NombreCategoria(categoria).ToLowerInvariant(),
                DatosContables.FormatearMonto(total));
            UiContable.EstilizarFila(dgvFlujo.Rows[fila], true, UiContable.RosaSuave);

            dgvFlujo.Rows.Add(string.Empty, string.Empty);
            return total;
        }

        private void AgregarLinea(string concepto, string importe)
        {
            dgvFlujo.Rows.Add(concepto, importe);
        }
    }
}
