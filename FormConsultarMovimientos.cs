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

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private ComboBox cboCuenta;
        private TextBox txtBuscar;
        private DataGridView dgvMovimientos;
        private Label lblEstado;
        private bool cargando;

        public FormConsultarMovimientos()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            Text = "Consultar Movimientos";
            BackColor = UiContable.Fondo;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);

            TableLayoutPanel raiz = UiContable.CrearRaiz(this, "CONSULTAR MOVIMIENTOS");

            FlowLayoutPanel filtros = UiContable.CrearBarra();
            filtros.Controls.Add(UiContable.Etiqueta("Desde:"));
            dtpDesde = UiContable.CrearFecha(DateTime.Today.AddMonths(-1));
            dtpDesde.ValueChanged += Filtro_ValueChanged;
            filtros.Controls.Add(dtpDesde);

            filtros.Controls.Add(UiContable.Etiqueta("Hasta:"));
            dtpHasta = UiContable.CrearFecha(DateTime.Today);
            dtpHasta.ValueChanged += Filtro_ValueChanged;
            filtros.Controls.Add(dtpHasta);

            filtros.Controls.Add(UiContable.Etiqueta("Cuenta:"));
            cboCuenta = UiContable.CrearCombo(330);
            cboCuenta.SelectedIndexChanged += Filtro_ValueChanged;
            filtros.Controls.Add(cboCuenta);

            filtros.Controls.Add(UiContable.Etiqueta("Buscar:"));
            txtBuscar = UiContable.CrearTexto(220);
            txtBuscar.MaxLength = 150;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            filtros.Controls.Add(txtBuscar);

            filtros.Controls.Add(UiContable.CrearBoton("Buscar movimientos", btnBuscar_Click));
            raiz.Controls.Add(filtros, 0, 1);

            dgvMovimientos = UiContable.CrearGrid();
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[]
            {
                UiContable.Columna("colFecha", "Fecha", 70F, false),
                UiContable.Columna("colNumero", "N° Asiento", 60F, true),
                UiContable.Columna("colReferencia", "Referencia", 85F, false),
                UiContable.Columna("colDescripcion", "Descripción", 150F, false),
                UiContable.Columna("colCodigo", "Código", 55F, false),
                UiContable.Columna("colCuenta", "Cuenta", 135F, false),
                UiContable.Columna("colDebe", "Debe", 75F, true),
                UiContable.Columna("colHaber", "Haber", 75F, true)
            });
            UiContable.AgregarContenido(raiz, UiContable.CrearTarjeta(dgvMovimientos));

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
