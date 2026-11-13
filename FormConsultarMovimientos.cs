using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormConsultarMovimientos : FormBase
    {
        private readonly List<CuentaContable> cuentas = new List<CuentaContable>();
        private readonly List<AsientoContable> asientos = new List<AsientoContable>();

        private bool cargando;

        public FormConsultarMovimientos()
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
                foreach (CuentaContable cuenta in cuentas.OrderBy(c => c.Codigo))
                    cboCuenta.Items.Add(cuenta);
                cboCuenta.SelectedIndex = 0;

                ConfigurarRangoFechas();
            }
            finally
            {
                cargando = false;
            }

            Consultar();
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
            Consultar();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.Handled = true;
            e.SuppressKeyPress = true;
            Consultar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            ManejadorErrores.Ejecutar(ConsultarInterno, "Error al consultar los movimientos");
        }

        private void ConsultarInterno()
        {
            if (cargando || dgvMovimientos == null) return;

            dgvMovimientos.Rows.Clear();

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "La fecha inicial no puede ser mayor que la fecha final.";
                return;
            }

            CuentaContable cuentaSeleccionada = cboCuenta.SelectedItem as CuentaContable;
            string codigoCuenta = cuentaSeleccionada == null ? string.Empty : cuentaSeleccionada.Codigo;
            string filtro = txtBuscar.Text.Trim().ToLowerInvariant();

            decimal totalDebe = 0m;
            decimal totalHaber = 0m;
            int movimientos = 0;
            int asientosSinFecha = 0;

            List<AsientoContable> ordenados = DatosContables.OrdenarPorFecha(asientos).ToList();

            foreach (AsientoContable asiento in ordenados)
            {
                if (!asiento.Fecha.HasValue)
                {
                    asientosSinFecha++;
                    continue;
                }

                if (asiento.Fecha.Value.Date < desde || asiento.Fecha.Value.Date > hasta) continue;

                foreach (PartidaContable partida in asiento.Partidas)
                {
                    if (codigoCuenta.Length > 0
                        && !string.Equals(partida.Cuenta, codigoCuenta, StringComparison.OrdinalIgnoreCase))
                        continue;

                    if (filtro.Length > 0)
                    {
                        string texto = (asiento.Referencia + " " + asiento.Descripcion + " "
                            + partida.Cuenta + " " + partida.NombreCuenta).ToLowerInvariant();
                        if (texto.IndexOf(filtro, StringComparison.Ordinal) < 0) continue;
                    }

                    dgvMovimientos.Rows.Add(
                        DatosContables.FormatearFecha(asiento.Fecha),
                        asiento.Numero.ToString(),
                        asiento.Referencia,
                        asiento.Descripcion,
                        partida.Cuenta,
                        partida.NombreCuenta,
                        DatosContables.MontoCelda(partida.Debe),
                        DatosContables.MontoCelda(partida.Haber));

                    totalDebe += partida.Debe;
                    totalHaber += partida.Haber;
                    movimientos++;
                }
            }

            if (movimientos == 0)
            {
                lblEstado.ForeColor = UiContable.Acento;
                lblEstado.Text = "No se encontraron movimientos para los filtros seleccionados.";
                return;
            }

            decimal diferencia = totalDebe - totalHaber;
            bool filtroParcial = codigoCuenta.Length > 0 || filtro.Length > 0;
            string mensaje = "Movimientos: " + movimientos
                + "   |   Total Debe: " + DatosContables.FormatearMonto(totalDebe)
                + "   |   Total Haber: " + DatosContables.FormatearMonto(totalHaber);

            // Con un filtro por cuenta o texto es normal que Debe y Haber no coincidan;
            // solo se advierte cuando se consultan todos los movimientos.
            if (!filtroParcial && Math.Abs(diferencia) >= 0.005m)
            {
                mensaje += "   |   Diferencia: " + DatosContables.FormatearMonto(diferencia);
                lblEstado.ForeColor = UiContable.Negativo;
            }
            else
            {
                lblEstado.ForeColor = filtroParcial ? UiContable.Acento : UiContable.Positivo;
            }

            int descuadrados = asientos.Count(a => !a.Cuadra);
            if (descuadrados > 0)
                mensaje += "   |   Asientos descuadrados en el archivo: " + descuadrados;
            if (asientosSinFecha > 0)
                mensaje += "   |   Asientos sin fecha válida: " + asientosSinFecha;

            lblEstado.Text = mensaje;
        }
    }
}
