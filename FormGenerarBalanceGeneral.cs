using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGenerarBalanceGeneral : FormBase
    {
        private readonly List<CuentaContable> cuentas = new List<CuentaContable>();
        private readonly List<AsientoContable> asientos = new List<AsientoContable>();

        private DateTimePicker dtpFecha;
        private DataGridView dgvBalance;
        private Label lblEstado;
        private bool cargando;

        public FormGenerarBalanceGeneral()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            Text = "Balance General";
            BackColor = UiContable.Fondo;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);

            TableLayoutPanel raiz = UiContable.CrearRaiz(this, "BALANCE GENERAL");

            FlowLayoutPanel filtros = UiContable.CrearBarra();
            filtros.Controls.Add(UiContable.Etiqueta("Al:"));
            dtpFecha = UiContable.CrearFecha(DateTime.Today);
            dtpFecha.ValueChanged += Filtro_ValueChanged;
            filtros.Controls.Add(dtpFecha);

            filtros.Controls.Add(UiContable.CrearBoton("Generar balance", btnGenerar_Click));
            raiz.Controls.Add(filtros, 0, 1);

            dgvBalance = UiContable.CrearGrid();
            dgvBalance.Columns.AddRange(new DataGridViewColumn[]
            {
                UiContable.Columna("colConcepto", "Concepto", 300F, false),
                UiContable.Columna("colImporte", "Importe", 110F, true)
            });
            UiContable.AgregarContenido(raiz, UiContable.CrearTarjeta(dgvBalance));

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

                DateTime? maxima = null;
                foreach (AsientoContable asiento in asientos)
                {
                    if (!asiento.Fecha.HasValue) continue;
                    if (!maxima.HasValue || asiento.Fecha.Value > maxima.Value) maxima = asiento.Fecha;
                }

                dtpFecha.Value = maxima.HasValue ? maxima.Value : DateTime.Today;
            }
            finally
            {
                cargando = false;
            }

            Generar();
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
            if (cargando || dgvBalance == null) return;

            dgvBalance.Rows.Clear();

            DateTime hasta = dtpFecha.Value.Date;
            List<CuentaContable> ordenadas = new List<CuentaContable>(cuentas);
            ordenadas.Sort((a, b) => string.Compare(a.Codigo, b.Codigo, StringComparison.OrdinalIgnoreCase));

            var totales = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);

            foreach (CuentaContable cuenta in ordenadas)
            {
                if (!cuenta.EsActivo && !cuenta.EsPasivo && !cuenta.EsPatrimonio) continue;
                totales[cuenta.Codigo] = DatosContables.SaldoEnFecha(cuenta, asientos, hasta);
            }

            Dictionary<string, CuentaContable> mapa = DatosContables.IndexarCuentas(cuentas);
            decimal resultado = DatosContables.CalcularResultadoAcumulado(asientos, mapa, hasta);

            decimal totalActivo = 0m;
            decimal totalPasivo = 0m;
            decimal totalPatrimonio = 0m;

            int fila = dgvBalance.Rows.Add("ACTIVO", string.Empty);
            UiContable.EstilizarFila(dgvBalance.Rows[fila], true, UiContable.EncabezadoTabla);

            bool hayActivo = false;
            foreach (CuentaContable cuenta in ordenadas)
            {
                if (!cuenta.EsActivo) continue;

                decimal saldo = totales[cuenta.Codigo];
                if (saldo == 0m) continue;

                hayActivo = true;
                totalActivo += saldo;
                dgvBalance.Rows.Add(cuenta.Codigo + " - " + cuenta.Nombre,
                    DatosContables.FormatearMonto(saldo));
            }
            if (!hayActivo) dgvBalance.Rows.Add("Sin cuentas de activo con saldo.", string.Empty);

            fila = dgvBalance.Rows.Add("TOTAL ACTIVO", DatosContables.FormatearMonto(totalActivo));
            UiContable.EstilizarFila(dgvBalance.Rows[fila], true, UiContable.RosaSuave);

            dgvBalance.Rows.Add(string.Empty, string.Empty);

            fila = dgvBalance.Rows.Add("PASIVO", string.Empty);
            UiContable.EstilizarFila(dgvBalance.Rows[fila], true, UiContable.EncabezadoTabla);

            bool hayPasivo = false;
            foreach (CuentaContable cuenta in ordenadas)
            {
                if (!cuenta.EsPasivo) continue;

                decimal saldo = totales[cuenta.Codigo];
                if (saldo == 0m) continue;

                hayPasivo = true;
                totalPasivo += saldo;
                dgvBalance.Rows.Add(cuenta.Codigo + " - " + cuenta.Nombre,
                    DatosContables.FormatearMonto(saldo));
            }
            if (!hayPasivo) dgvBalance.Rows.Add("Sin cuentas de pasivo con saldo.", string.Empty);

            fila = dgvBalance.Rows.Add("TOTAL PASIVO", DatosContables.FormatearMonto(totalPasivo));
            UiContable.EstilizarFila(dgvBalance.Rows[fila], true, UiContable.RosaSuave);

            dgvBalance.Rows.Add(string.Empty, string.Empty);

            fila = dgvBalance.Rows.Add("PATRIMONIO", string.Empty);
            UiContable.EstilizarFila(dgvBalance.Rows[fila], true, UiContable.EncabezadoTabla);

            bool hayPatrimonio = false;
            foreach (CuentaContable cuenta in ordenadas)
            {
                if (!cuenta.EsPatrimonio) continue;

                decimal saldo = totales[cuenta.Codigo];
                if (saldo == 0m) continue;

                hayPatrimonio = true;
                totalPatrimonio += saldo;
                dgvBalance.Rows.Add(cuenta.Codigo + " - " + cuenta.Nombre,
                    DatosContables.FormatearMonto(saldo));
            }
            if (!hayPatrimonio) dgvBalance.Rows.Add("Sin cuentas de patrimonio con saldo.", string.Empty);

            if (resultado != 0m)
            {
                totalPatrimonio += resultado;
                dgvBalance.Rows.Add("Resultado del ejercicio (calculado)",
                    DatosContables.FormatearMonto(resultado));
            }

            fila = dgvBalance.Rows.Add("TOTAL PATRIMONIO", DatosContables.FormatearMonto(totalPatrimonio));
            UiContable.EstilizarFila(dgvBalance.Rows[fila], true, UiContable.RosaSuave);

            dgvBalance.Rows.Add(string.Empty, string.Empty);

            decimal pasivoPatrimonio = totalPasivo + totalPatrimonio;
            decimal diferencia = totalActivo - pasivoPatrimonio;

            fila = dgvBalance.Rows.Add("TOTAL PASIVO + PATRIMONIO",
                DatosContables.FormatearMonto(pasivoPatrimonio));
            UiContable.EstilizarFila(dgvBalance.Rows[fila], true, UiContable.EncabezadoTabla);

            fila = dgvBalance.Rows.Add("DIFERENCIA (Activo - Pasivo y Patrimonio)",
                DatosContables.FormatearMonto(diferencia));
            UiContable.EstilizarFila(dgvBalance.Rows[fila], true,
                Math.Abs(diferencia) < 0.005m ? Color.FromArgb(232, 245, 233) : Color.FromArgb(255, 235, 238));
            dgvBalance.Rows[fila].Cells[1].Style.ForeColor =
                Math.Abs(diferencia) < 0.005m ? UiContable.Positivo : UiContable.Negativo;

            string mensaje = "Al " + hasta.ToString("dd/MM/yyyy")
                + "   |   Activo: " + DatosContables.FormatearMonto(totalActivo)
                + "   |   Pasivo: " + DatosContables.FormatearMonto(totalPasivo)
                + "   |   Patrimonio: " + DatosContables.FormatearMonto(totalPatrimonio)
                + "   |   Diferencia: " + DatosContables.FormatearMonto(diferencia);

            if (Math.Abs(diferencia) < 0.005m)
            {
                lblEstado.ForeColor = UiContable.Positivo;
                lblEstado.Text = mensaje + "   |   Balance cuadrado.";
            }
            else
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = mensaje + "   |   El balance no cuadra. Revise los saldos iniciales o los asientos registrados.";
            }
        }
    }
}
