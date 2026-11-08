using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Calcula el pago de una venta aplicando, cuando corresponde, el
    /// descuento por pago en efectivo. Toda la interfaz usa controles
    /// nativos de Windows Forms.
    /// </summary>
    public class FormPagoVentas : FormBase
    {
        private const decimal SubtotalMinimo = 1m;
        private const decimal SubtotalMaximo = 50000m;
        private const string TipoEfectivo = "Efectivo";
        private const string TipoTarjeta = "Tarjeta";
        private const string TipoTransferencia = "Transferencia";
        private const string TipoRetiroSinTarjeta = "Retiro sin tarjeta";

        private readonly Container componentes = new Container();
        private readonly List<VentaCalculada> ventas = new List<VentaCalculada>();
        private ErrorProvider errorProvider;
        private TextBox txtSubtotal;
        private ComboBox cboTipoPago;
        private CheckBox chkDescuento;
        private Label lblTasaDescuento;
        private Label lblResumenSubtotal;
        private Label lblResumenTipo;
        private Label lblResumenTasa;
        private Label lblResumenDescuento;
        private Label lblTotal;
        private Label lblEstado;
        private Label lblTotalVendido;
        private Button btnCalcular;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnLimpiarHistorial;
        private DataGridView gridVentas;
        private decimal totalVendido;

        private class VentaCalculada
        {
            public decimal Subtotal;
            public string TipoPago;
            public bool AplicaDescuento;
            public decimal Porcentaje;
            public decimal Descuento;
            public decimal Total;
            public DateTime Fecha;
        }

        public FormPagoVentas()
        {
            ConstruirInterfaz();
            CargarTiposPago();
            LimpiarFormulario();
        }

        protected override void OnPrepararContenido()
        {
            base.OnPrepararContenido();
            LimpiarFormulario();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                componentes.Dispose();

            base.Dispose(disposing);
        }

        private void ConstruirInterfaz()
        {
            SuspendLayout();

            BackColor = UiContable.Fondo;
            Text = "Cálculo de pago por ventas";
            AutoScaleMode = AutoScaleMode.Font;
            MinimumSize = new Size(900, 600);

            errorProvider = new ErrorProvider(componentes);
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;

            TableLayoutPanel raiz = UiContable.CrearRaiz(this, "Cálculo de pago por ventas");

            var subtitulo = new Label();
            subtitulo.AutoSize = true;
            subtitulo.Font = UiContable.Fuente(10F);
            subtitulo.ForeColor = UiContable.AcentoFuerte;
            subtitulo.Text = "Registre el subtotal, seleccione el tipo de pago y calcule el total a cobrar.";
            subtitulo.Margin = new Padding(0, 0, 0, 12);
            raiz.Controls.Add(subtitulo, 0, 1);

            var contenido = new TableLayoutPanel();
            contenido.Dock = DockStyle.Fill;
            contenido.BackColor = Color.Transparent;
            contenido.ColumnCount = 2;
            contenido.RowCount = 2;
            contenido.Margin = Padding.Empty;
            contenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
            contenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            contenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 276F));
            contenido.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            GroupBox grupoDatos = CrearGrupo("Datos de la venta");
            grupoDatos.Margin = new Padding(0, 0, 8, 8);
            contenido.Controls.Add(grupoDatos, 0, 0);

            GroupBox grupoResumen = CrearGrupo("Resumen del pago");
            grupoResumen.Margin = new Padding(8, 0, 0, 8);
            contenido.Controls.Add(grupoResumen, 1, 0);

            GroupBox grupoHistorial = CrearGrupo("Ventas registradas en esta sesión");
            grupoHistorial.Margin = new Padding(0, 8, 0, 0);
            contenido.Controls.Add(grupoHistorial, 0, 1);
            contenido.SetColumnSpan(grupoHistorial, 2);

            ConstruirDatosVenta(grupoDatos);
            ConstruirResumen(grupoResumen);
            ConstruirHistorial(grupoHistorial);

            UiContable.AgregarContenido(raiz, contenido);

            lblEstado = UiContable.CrearEstado();
            lblEstado.Name = "lblEstado";
            raiz.Controls.Add(lblEstado, 0, 3);

            AcceptButton = btnCalcular;

            ResumeLayout(true);
        }

        private static GroupBox CrearGrupo(string titulo)
        {
            var grupo = new GroupBox();
            grupo.Text = titulo;
            grupo.Dock = DockStyle.Fill;
            grupo.BackColor = Color.White;
            grupo.ForeColor = UiContable.Acento;
            grupo.Font = UiContable.FuenteNegrita(10F);
            grupo.Padding = new Padding(12, 8, 12, 10);
            return grupo;
        }

        private void ConstruirDatosVenta(GroupBox grupo)
        {
            var tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.BackColor = Color.Transparent;
            tlp.ColumnCount = 2;
            tlp.RowCount = 7;
            tlp.Margin = Padding.Empty;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 178F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            for (int i = 0; i < 7; i++)
                tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Label lblSubtotal = UiContable.Etiqueta("Subtotal de la venta:");
            tlp.Controls.Add(lblSubtotal, 0, 0);

            txtSubtotal = UiContable.CrearTexto(190);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.MaxLength = 16;
            txtSubtotal.Anchor = AnchorStyles.Left;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            tlp.Controls.Add(txtSubtotal, 1, 0);

            var lblAyudaSubtotal = new Label();
            lblAyudaSubtotal.AutoSize = true;
            lblAyudaSubtotal.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic, GraphicsUnit.Point);
            lblAyudaSubtotal.ForeColor = UiContable.AcentoFuerte;
            lblAyudaSubtotal.Text = "Entre 1.00 y 50,000.00. Se permiten hasta 2 decimales.";
            lblAyudaSubtotal.Margin = new Padding(0, 0, 0, 7);
            tlp.Controls.Add(lblAyudaSubtotal, 0, 1);
            tlp.SetColumnSpan(lblAyudaSubtotal, 2);

            Label lblTipoPago = UiContable.Etiqueta("Tipo de pago:");
            tlp.Controls.Add(lblTipoPago, 0, 2);

            cboTipoPago = UiContable.CrearCombo(220);
            cboTipoPago.Name = "cboTipoPago";
            cboTipoPago.Anchor = AnchorStyles.Left;
            cboTipoPago.SelectedIndexChanged += cboTipoPago_SelectedIndexChanged;
            tlp.Controls.Add(cboTipoPago, 1, 2);

            chkDescuento = UiContable.CrearCheck("Aplicar descuento (solo para pago en efectivo)", false);
            chkDescuento.Name = "chkDescuento";
            chkDescuento.Enabled = false;
            chkDescuento.CheckedChanged += chkDescuento_CheckedChanged;
            tlp.Controls.Add(chkDescuento, 0, 3);
            tlp.SetColumnSpan(chkDescuento, 2);

            lblTasaDescuento = new Label();
            lblTasaDescuento.AutoSize = true;
            lblTasaDescuento.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTasaDescuento.ForeColor = UiContable.Acento;
            lblTasaDescuento.Text = "Seleccione Efectivo para habilitar el descuento.";
            lblTasaDescuento.Margin = new Padding(2, 2, 0, 7);
            tlp.Controls.Add(lblTasaDescuento, 0, 4);
            tlp.SetColumnSpan(lblTasaDescuento, 2);

            var lblTarifas = new Label();
            lblTarifas.AutoSize = true;
            lblTarifas.MaximumSize = new Size(520, 0);
            lblTarifas.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblTarifas.ForeColor = Color.FromArgb(105, 82, 70);
            lblTarifas.Text = "Descuentos por subtotal:  1.00 - 2,000.00 = 2%   |   " +
                "2,000.01 - 3,500.00 = 3%   |   más de 3,500.00 = 5%";
            lblTarifas.Margin = new Padding(2, 0, 0, 4);
            tlp.Controls.Add(lblTarifas, 0, 5);
            tlp.SetColumnSpan(lblTarifas, 2);

            FlowLayoutPanel barra = UiContable.CrearBarra();
            barra.Margin = new Padding(0, 4, 0, 0);
            btnCalcular = UiContable.CrearBoton("Calcular pago", btnCalcular_Click);
            btnLimpiar = UiContable.CrearBoton("Limpiar", btnLimpiar_Click);
            barra.Controls.Add(btnCalcular);
            barra.Controls.Add(btnLimpiar);
            tlp.Controls.Add(barra, 0, 6);
            tlp.SetColumnSpan(barra, 2);

            grupo.Controls.Add(tlp);
        }

        private void ConstruirResumen(GroupBox grupo)
        {
            var tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.BackColor = Color.Transparent;
            tlp.ColumnCount = 2;
            tlp.RowCount = 8;
            tlp.Margin = Padding.Empty;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            for (int i = 0; i < 8; i++)
                tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            lblResumenSubtotal = AgregarFilaResumen(tlp, 0, "Subtotal");
            lblResumenTipo = AgregarFilaResumen(tlp, 1, "Tipo de pago");
            lblResumenTasa = AgregarFilaResumen(tlp, 2, "Porcentaje de descuento");
            lblResumenDescuento = AgregarFilaResumen(tlp, 3, "Monto del descuento");

            var separador = new Panel();
            separador.Dock = DockStyle.Fill;
            separador.Height = 1;
            separador.BackColor = Color.Gainsboro;
            separador.Margin = new Padding(0, 8, 0, 8);
            tlp.Controls.Add(separador, 0, 4);
            tlp.SetColumnSpan(separador, 2);

            var lblTituloTotal = new Label();
            lblTituloTotal.Dock = DockStyle.Fill;
            lblTituloTotal.AutoSize = false;
            lblTituloTotal.Height = 44;
            lblTituloTotal.Font = UiContable.FuenteNegrita(11F);
            lblTituloTotal.ForeColor = UiContable.Acento;
            lblTituloTotal.Text = "TOTAL A PAGAR";
            lblTituloTotal.TextAlign = ContentAlignment.MiddleLeft;
            lblTituloTotal.Margin = Padding.Empty;
            tlp.Controls.Add(lblTituloTotal, 0, 5);

            lblTotal = new Label();
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.AutoSize = false;
            lblTotal.Height = 44;
            lblTotal.Font = new Font("Georgia", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = UiContable.AcentoFuerte;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Margin = Padding.Empty;
            tlp.Controls.Add(lblTotal, 1, 5);

            var lblNota = new Label();
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic, GraphicsUnit.Point);
            lblNota.ForeColor = Color.FromArgb(105, 82, 70);
            lblNota.Text = "El descuento se calcula sobre el subtotal y solo aplica al pago en efectivo.";
            lblNota.Margin = new Padding(0, 4, 0, 6);
            tlp.Controls.Add(lblNota, 0, 6);
            tlp.SetColumnSpan(lblNota, 2);

            btnRegistrar = UiContable.CrearBoton("Registrar venta", btnRegistrar_Click);
            btnRegistrar.Enabled = false;
            btnRegistrar.Anchor = AnchorStyles.Right;
            btnRegistrar.Margin = new Padding(0, 4, 0, 0);
            tlp.Controls.Add(btnRegistrar, 0, 7);
            tlp.SetColumnSpan(btnRegistrar, 2);

            grupo.Controls.Add(tlp);
        }

        private static Label AgregarFilaResumen(TableLayoutPanel tlp, int fila, string texto)
        {
            var etiqueta = new Label();
            etiqueta.Dock = DockStyle.Fill;
            etiqueta.AutoSize = false;
            etiqueta.Height = 26;
            etiqueta.Font = UiContable.Fuente(10F);
            etiqueta.ForeColor = UiContable.Texto;
            etiqueta.Text = texto;
            etiqueta.TextAlign = ContentAlignment.MiddleLeft;
            etiqueta.Margin = Padding.Empty;
            tlp.Controls.Add(etiqueta, 0, fila);

            var valor = new Label();
            valor.Dock = DockStyle.Fill;
            valor.AutoSize = false;
            valor.Height = 26;
            valor.Font = UiContable.FuenteNegrita(10F);
            valor.ForeColor = UiContable.Acento;
            valor.Text = "—";
            valor.TextAlign = ContentAlignment.MiddleRight;
            valor.Margin = Padding.Empty;
            tlp.Controls.Add(valor, 1, fila);

            return valor;
        }

        private void ConstruirHistorial(GroupBox grupo)
        {
            var tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.BackColor = Color.Transparent;
            tlp.ColumnCount = 1;
            tlp.RowCount = 2;
            tlp.Margin = Padding.Empty;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            gridVentas = UiContable.CrearGrid();
            gridVentas.Name = "gridVentas";
            gridVentas.Columns.Add(UiContable.Columna("numero", "N.º", 7F, false, 42));
            gridVentas.Columns.Add(UiContable.Columna("hora", "Hora", 12F, false, 62));
            gridVentas.Columns.Add(UiContable.Columna("subtotal", "Subtotal", 16F, true));
            gridVentas.Columns.Add(UiContable.Columna("tipo", "Tipo de pago", 20F, false));
            gridVentas.Columns.Add(UiContable.Columna("porcentaje", "% Desc.", 10F, true));
            gridVentas.Columns.Add(UiContable.Columna("descuento", "Descuento", 16F, true));
            gridVentas.Columns.Add(UiContable.Columna("total", "Total pagado", 19F, true));
            tlp.Controls.Add(gridVentas, 0, 0);

            var pie = new TableLayoutPanel();
            pie.Dock = DockStyle.Fill;
            pie.AutoSize = true;
            pie.BackColor = Color.Transparent;
            pie.ColumnCount = 2;
            pie.RowCount = 1;
            pie.Margin = Padding.Empty;
            pie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pie.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            pie.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            lblTotalVendido = new Label();
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Anchor = AnchorStyles.Left;
            lblTotalVendido.Font = UiContable.FuenteNegrita(10F);
            lblTotalVendido.ForeColor = UiContable.Acento;
            lblTotalVendido.Text = "Total vendido en esta sesión: " + FormatearMonto(0m);
            lblTotalVendido.Margin = new Padding(0, 10, 0, 0);
            pie.Controls.Add(lblTotalVendido, 0, 0);

            btnLimpiarHistorial = UiContable.CrearBoton("Limpiar historial", btnLimpiarHistorial_Click);
            btnLimpiarHistorial.Anchor = AnchorStyles.Right;
            btnLimpiarHistorial.Margin = new Padding(0, 4, 0, 0);
            pie.Controls.Add(btnLimpiarHistorial, 1, 0);

            tlp.Controls.Add(pie, 0, 1);
            grupo.Controls.Add(tlp);
        }

        private void CargarTiposPago()
        {
            cboTipoPago.Items.Clear();
            cboTipoPago.Items.Add(TipoEfectivo);
            cboTipoPago.Items.Add(TipoTarjeta);
            cboTipoPago.Items.Add(TipoTransferencia);
            cboTipoPago.Items.Add(TipoRetiroSinTarjeta);
            cboTipoPago.SelectedIndex = -1;
        }

        private string ObtenerTipoPagoSeleccionado()
        {
            if (cboTipoPago == null || cboTipoPago.SelectedIndex < 0)
                return "";

            return cboTipoPago.SelectedItem as string ?? "";
        }

        private bool EsPagoEnEfectivo()
        {
            return string.Equals(ObtenerTipoPagoSeleccionado(), TipoEfectivo,
                StringComparison.OrdinalIgnoreCase);
        }

        private static bool TryParseMonto(string texto, out decimal monto)
        {
            monto = 0m;
            string limpio = (texto ?? "").Trim().Replace(" ", "");
            if (limpio.Length == 0) return false;

            if (decimal.TryParse(limpio, NumberStyles.Number, CultureInfo.CurrentCulture, out monto))
                return true;

            if (decimal.TryParse(limpio, NumberStyles.Number, CultureInfo.InvariantCulture, out monto))
                return true;

            int coma = limpio.IndexOf(',');
            if (coma > 0 && coma == limpio.LastIndexOf(','))
            {
                string alterno = limpio.Replace(".", "").Replace(',', '.');
                if (decimal.TryParse(alterno, NumberStyles.Number,
                    CultureInfo.InvariantCulture, out monto))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Valida únicamente el subtotal, sin mostrar mensajes. Se usa para
        /// actualizar la vista previa del descuento mientras se escribe.
        /// </summary>
        private bool TryObtenerSubtotal(out decimal subtotal)
        {
            subtotal = 0m;
            string texto = txtSubtotal == null ? "" : txtSubtotal.Text.Trim();
            if (!TryParseMonto(texto, out subtotal))
                return false;

            if (subtotal < SubtotalMinimo || subtotal > SubtotalMaximo)
                return false;

            if (decimal.Round(subtotal, 2) != subtotal)
                return false;

            return true;
        }

        private static decimal ObtenerPorcentajeDescuento(decimal subtotal)
        {
            if (subtotal <= 2000m) return 2m;
            if (subtotal <= 3500m) return 3m;
            return 5m;
        }

        private static string FormatearMonto(decimal monto)
        {
            return monto.ToString("N2", CultureInfo.CurrentCulture);
        }

        private static string FormatearPorcentaje(decimal porcentaje)
        {
            return porcentaje.ToString("0.##", CultureInfo.CurrentCulture) + "%";
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            ActualizarDescuentoVisual();
            InvalidarCalculo();
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDescuentoVisual();
            InvalidarCalculo();
        }

        private void chkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDescuentoVisual();
            InvalidarCalculo();
        }

        private void ActualizarDescuentoVisual()
        {
            if (chkDescuento == null || lblTasaDescuento == null)
                return;

            bool efectivo = EsPagoEnEfectivo();
            chkDescuento.Enabled = efectivo;

            if (!efectivo)
            {
                if (chkDescuento.Checked)
                {
                    chkDescuento.Checked = false;
                    return;
                }

                lblTasaDescuento.ForeColor = Color.FromArgb(105, 82, 70);
                lblTasaDescuento.Text = "El descuento solo aplica a pagos en efectivo.";
                return;
            }

            if (!chkDescuento.Checked)
            {
                lblTasaDescuento.ForeColor = UiContable.Acento;
                lblTasaDescuento.Text = "Descuento no aplicado (0%).";
                return;
            }

            decimal subtotal;
            if (!TryObtenerSubtotal(out subtotal))
            {
                lblTasaDescuento.ForeColor = UiContable.Acento;
                lblTasaDescuento.Text = "Ingrese un subtotal válido para conocer el descuento.";
                return;
            }

            decimal porcentaje = ObtenerPorcentajeDescuento(subtotal);
            decimal descuento = decimal.Round(subtotal * porcentaje / 100m, 2,
                MidpointRounding.AwayFromZero);

            lblTasaDescuento.ForeColor = UiContable.Positivo;
            lblTasaDescuento.Text = "Descuento aplicable: " + FormatearPorcentaje(porcentaje)
                + " (" + FormatearMonto(descuento) + ").";
        }

        private void InvalidarCalculo()
        {
            if (btnRegistrar != null)
                btnRegistrar.Enabled = false;

            LimpiarResumen();
        }

        private void LimpiarResumen()
        {
            if (lblResumenSubtotal == null) return;

            lblResumenSubtotal.Text = "—";
            lblResumenTipo.Text = "—";
            lblResumenTasa.Text = "—";
            lblResumenDescuento.Text = "—";
            lblResumenTasa.ForeColor = UiContable.Acento;
            lblResumenDescuento.ForeColor = UiContable.Acento;
            lblTotal.Text = FormatearMonto(0m);
            lblTotal.ForeColor = UiContable.AcentoFuerte;
        }

        private void MostrarResumen(VentaCalculada venta)
        {
            lblResumenSubtotal.Text = FormatearMonto(venta.Subtotal);
            lblResumenTipo.Text = venta.TipoPago;
            lblResumenTasa.Text = venta.AplicaDescuento
                ? FormatearPorcentaje(venta.Porcentaje)
                : "0%";
            lblResumenDescuento.Text = venta.AplicaDescuento
                ? "- " + FormatearMonto(venta.Descuento)
                : "No aplica";
            lblResumenTasa.ForeColor = venta.AplicaDescuento
                ? UiContable.Positivo
                : UiContable.Acento;
            lblResumenDescuento.ForeColor = venta.AplicaDescuento
                ? UiContable.Negativo
                : UiContable.Acento;
            lblTotal.Text = FormatearMonto(venta.Total);
            lblTotal.ForeColor = UiContable.Positivo;
        }

        private bool ValidarEntrada(out decimal subtotal, out string tipoPago,
            out bool aplicaDescuento)
        {
            subtotal = 0m;
            tipoPago = "";
            aplicaDescuento = false;

            if (errorProvider != null)
                errorProvider.Clear();

            bool valido = true;
            string texto = txtSubtotal.Text.Trim();

            if (texto.Length == 0)
            {
                errorProvider.SetError(txtSubtotal, "Ingrese el subtotal de la venta.");
                valido = false;
            }
            else if (!TryParseMonto(texto, out subtotal))
            {
                errorProvider.SetError(txtSubtotal,
                    "El subtotal debe ser un número válido (ejemplo: 1500.50).");
                valido = false;
            }
            else if (subtotal < SubtotalMinimo || subtotal > SubtotalMaximo)
            {
                errorProvider.SetError(txtSubtotal,
                    "El subtotal debe estar entre 1.00 y 50,000.00.");
                valido = false;
            }
            else if (decimal.Round(subtotal, 2) != subtotal)
            {
                errorProvider.SetError(txtSubtotal,
                    "El subtotal no puede tener más de dos decimales.");
                valido = false;
            }

            tipoPago = ObtenerTipoPagoSeleccionado();
            if (tipoPago.Length == 0)
            {
                errorProvider.SetError(cboTipoPago, "Seleccione un tipo de pago.");
                valido = false;
            }

            if (chkDescuento.Checked && !EsPagoEnEfectivo())
            {
                errorProvider.SetError(chkDescuento,
                    "El descuento solo puede aplicarse cuando el pago es en efectivo.");
                valido = false;
            }

            if (!valido)
            {
                if (txtSubtotal.Text.Trim().Length == 0 || !TryObtenerSubtotal(out subtotal))
                    txtSubtotal.Focus();
                else if (tipoPago.Length == 0)
                    cboTipoPago.Focus();
                else
                    chkDescuento.Focus();

                return false;
            }

            aplicaDescuento = string.Equals(tipoPago, TipoEfectivo,
                StringComparison.OrdinalIgnoreCase) && chkDescuento.Checked;
            return true;
        }

        private bool CalcularVenta(out VentaCalculada venta)
        {
            venta = null;

            decimal subtotal;
            string tipoPago;
            bool aplicaDescuento;

            if (!ValidarEntrada(out subtotal, out tipoPago, out aplicaDescuento))
                return false;

            decimal porcentaje = aplicaDescuento
                ? ObtenerPorcentajeDescuento(subtotal)
                : 0m;
            decimal descuento = decimal.Round(subtotal * porcentaje / 100m, 2,
                MidpointRounding.AwayFromZero);
            decimal total = decimal.Round(subtotal - descuento, 2,
                MidpointRounding.AwayFromZero);

            if (descuento < 0m || total < 0m || total > subtotal)
            {
                errorProvider.SetError(txtSubtotal,
                    "No fue posible calcular un total válido. Revise los datos.");
                return false;
            }

            venta = new VentaCalculada();
            venta.Subtotal = subtotal;
            venta.TipoPago = tipoPago;
            venta.AplicaDescuento = aplicaDescuento;
            venta.Porcentaje = porcentaje;
            venta.Descuento = descuento;
            venta.Total = total;
            venta.Fecha = DateTime.Now;

            MostrarResumen(venta);
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            VentaCalculada venta;
            if (!CalcularVenta(out venta))
            {
                MostrarEstado("Corrija los datos marcados para continuar.", UiContable.Negativo);
                return;
            }

            btnRegistrar.Enabled = true;
            MostrarEstado("Cálculo realizado. Puede registrar la venta en el historial.",
                UiContable.Positivo);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            VentaCalculada venta;
            if (!CalcularVenta(out venta))
            {
                MostrarEstado("No se pudo registrar la venta. Revise los datos marcados.",
                    UiContable.Negativo);
                return;
            }

            ventas.Add(venta);
            int numero = ventas.Count;

            gridVentas.Rows.Add(
                numero.ToString(CultureInfo.CurrentCulture),
                venta.Fecha.ToString("HH:mm:ss", CultureInfo.CurrentCulture),
                FormatearMonto(venta.Subtotal),
                venta.TipoPago,
                venta.AplicaDescuento ? FormatearPorcentaje(venta.Porcentaje) : "0%",
                venta.AplicaDescuento ? FormatearMonto(venta.Descuento) : "0.00",
                FormatearMonto(venta.Total));

            totalVendido += venta.Total;
            lblTotalVendido.Text = "Total vendido en esta sesión: " + FormatearMonto(totalVendido);

            if (gridVentas.Rows.Count > 0)
            {
                gridVentas.ClearSelection();
                gridVentas.FirstDisplayedScrollingRowIndex = gridVentas.Rows.Count - 1;
            }

            btnRegistrar.Enabled = false;
            errorProvider.Clear();
            MostrarEstado("Venta registrada correctamente en el historial.", UiContable.Positivo);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            if (ventas.Count == 0)
            {
                MostrarEstado("Todavía no hay ventas registradas para limpiar.", UiContable.Acento);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar todas las ventas del historial de esta sesión?",
                "Limpiar historial", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (respuesta != DialogResult.Yes) return;

            ventas.Clear();
            gridVentas.Rows.Clear();
            totalVendido = 0m;
            lblTotalVendido.Text = "Total vendido en esta sesión: " + FormatearMonto(0m);
            MostrarEstado("Historial de ventas limpiado.", UiContable.Positivo);
        }

        private void LimpiarFormulario()
        {
            if (txtSubtotal == null) return;

            txtSubtotal.Clear();
            if (cboTipoPago != null)
                cboTipoPago.SelectedIndex = -1;
            if (chkDescuento != null)
            {
                chkDescuento.Checked = false;
                chkDescuento.Enabled = false;
            }

            if (lblTasaDescuento != null)
            {
                lblTasaDescuento.ForeColor = UiContable.Acento;
                lblTasaDescuento.Text = "Seleccione Efectivo para habilitar el descuento.";
            }

            if (btnRegistrar != null)
                btnRegistrar.Enabled = false;

            if (errorProvider != null)
                errorProvider.Clear();

            LimpiarResumen();
            MostrarEstado("Ingrese el subtotal y seleccione el tipo de pago.", UiContable.Acento);

            if (IsHandleCreated && Visible)
                txtSubtotal.Focus();
        }

        private void MostrarEstado(string texto, Color color)
        {
            if (lblEstado == null) return;
            lblEstado.Text = texto;
            lblEstado.ForeColor = color;
        }
    }
}
