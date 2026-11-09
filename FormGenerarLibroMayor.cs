using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGenerarLibroMayor : FormBase
    {
        private readonly List<CuentaContable> cuentas = new List<CuentaContable>();
        private readonly List<AsientoContable> asientos = new List<AsientoContable>();

        private bool cargando;

        private sealed class MovimientoMayor
        {
            public AsientoContable Asiento;
            public PartidaContable Partida;
            public decimal Efecto;
        }

        public FormGenerarLibroMayor()
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

                cboCuenta.Items.Clear();
                cboCuenta.Items.Add(new CuentaContable { Codigo = string.Empty, Nombre = "Todas las cuentas" });
                foreach (CuentaContable cuenta in cuentas)
                    cboCuenta.Items.Add(cuenta);
                cboCuenta.SelectedIndex = 0;

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
            if (cargando || dgvMayor == null) return;

            dgvMayor.Rows.Clear();

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "La fecha inicial no puede ser mayor que la fecha final.";
                return;
            }

            CuentaContable seleccionada = cboCuenta.SelectedItem as CuentaContable;
            string codigo = seleccionada == null ? string.Empty : seleccionada.Codigo;
            bool ocultarVacios = chkOcultarVacios.Checked;

            List<AsientoContable> ordenados = DatosContables.OrdenarPorFecha(asientos).ToList();
            int cuentasIncluidas = 0;
            int totalPartidas = 0;
            decimal totalDebe = 0m;
            decimal totalHaber = 0m;

            List<CuentaContable> cuentasOrdenadas = new List<CuentaContable>(cuentas);
            cuentasOrdenadas.Sort((a, b) => string.Compare(a.Codigo, b.Codigo, StringComparison.OrdinalIgnoreCase));

            foreach (CuentaContable cuenta in cuentasOrdenadas)
            {
                if (codigo.Length > 0 && !string.Equals(cuenta.Codigo, codigo, StringComparison.OrdinalIgnoreCase))
                    continue;

                decimal saldoAnterior = DatosContables.SaldoEnFecha(cuenta, ordenados, hasta)
                    - DatosContables.EfectoEnRango(cuenta, ordenados, desde, hasta);

                var movimientos = new List<MovimientoMayor>();
                foreach (AsientoContable asiento in ordenados)
                {
                    if (!asiento.Fecha.HasValue) continue;
                    if (asiento.Fecha.Value.Date < desde || asiento.Fecha.Value.Date > hasta) continue;

                    foreach (PartidaContable partida in asiento.Partidas)
                    {
                        if (!string.Equals(partida.Cuenta, cuenta.Codigo, StringComparison.OrdinalIgnoreCase))
                            continue;

                        movimientos.Add(new MovimientoMayor
                        {
                            Asiento = asiento,
                            Partida = partida,
                            Efecto = DatosContables.EfectoEnNaturaleza(cuenta, partida.Debe, partida.Haber)
                        });
                    }
                }

                if (ocultarVacios && movimientos.Count == 0 && saldoAnterior == 0m)
                    continue;

                decimal saldo = saldoAnterior;
                decimal debeCuenta = 0m;
                decimal haberCuenta = 0m;

                string encabezado = "CUENTA " + cuenta.Codigo + " - " + cuenta.Nombre;
                int filaEncabezado = dgvMayor.Rows.Add(
                    encabezado,
                    string.Empty,
                    string.Empty,
                    "SALDO ANTERIOR",
                    string.Empty,
                    string.Empty,
                    DatosContables.FormatearMonto(saldoAnterior));
                UiContable.EstilizarFila(dgvMayor.Rows[filaEncabezado], true, UiContable.EncabezadoTabla);

                foreach (MovimientoMayor movimiento in movimientos)
                {
                    saldo += movimiento.Efecto;
                    debeCuenta += movimiento.Partida.Debe;
                    haberCuenta += movimiento.Partida.Haber;
                    totalDebe += movimiento.Partida.Debe;
                    totalHaber += movimiento.Partida.Haber;
                    totalPartidas++;

                    int fila = dgvMayor.Rows.Add(
                        string.Empty,
                        DatosContables.FormatearFecha(movimiento.Asiento.Fecha),
                        movimiento.Asiento.Referencia,
                        movimiento.Asiento.Descripcion,
                        DatosContables.MontoCelda(movimiento.Partida.Debe),
                        DatosContables.MontoCelda(movimiento.Partida.Haber),
                        DatosContables.FormatearMonto(saldo));

                    if (saldo < 0m)
                        dgvMayor.Rows[fila].Cells[6].Style.ForeColor = UiContable.Negativo;
                    else if (saldo > 0m)
                        dgvMayor.Rows[fila].Cells[6].Style.ForeColor = UiContable.Positivo;
                }

                int filaFinal = dgvMayor.Rows.Add(
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    "SALDO FINAL",
                    DatosContables.FormatearMonto(debeCuenta),
                    DatosContables.FormatearMonto(haberCuenta),
                    DatosContables.FormatearMonto(saldo));
                UiContable.EstilizarFila(dgvMayor.Rows[filaFinal], true, UiContable.RosaSuave);

                cuentasIncluidas++;
            }

            if (cuentasIncluidas == 0)
            {
                lblEstado.ForeColor = UiContable.Acento;
                lblEstado.Text = "No hay cuentas con saldo ni movimientos para el período seleccionado.";
                return;
            }

            decimal diferencia = totalDebe - totalHaber;
            string mensaje = "Cuentas: " + cuentasIncluidas
                + "   |   Movimientos: " + totalPartidas
                + "   |   Debe: " + DatosContables.FormatearMonto(totalDebe)
                + "   |   Haber: " + DatosContables.FormatearMonto(totalHaber);

            // Al filtrar una sola cuenta es normal que Debe y Haber no coincidan.
            if (codigo.Length == 0 && Math.Abs(diferencia) >= 0.005m)
            {
                mensaje += "   |   Diferencia: " + DatosContables.FormatearMonto(diferencia);
                lblEstado.ForeColor = UiContable.Negativo;
            }
            else
            {
                lblEstado.ForeColor = codigo.Length > 0 ? UiContable.Acento : UiContable.Positivo;
            }

            int asientosSinFecha = 0;
            int asientosDescuadrados = 0;
            foreach (AsientoContable asiento in asientos)
            {
                if (!asiento.Fecha.HasValue) asientosSinFecha++;
                if (!asiento.Cuadra) asientosDescuadrados++;
            }

            if (asientosSinFecha > 0)
                mensaje += "   |   Asientos sin fecha válida: " + asientosSinFecha;
            if (asientosDescuadrados > 0)
                mensaje += "   |   Asientos descuadrados: " + asientosDescuadrados;

            lblEstado.Text = mensaje;
        }
    }
}
