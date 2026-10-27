namespace WindowsFormsApp1
{
    partial class FormRegistrarOperaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpFondo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tcOperaciones = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.tlpNuevo = new System.Windows.Forms.TableLayoutPanel();
            this.panelEncabezado = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumeroAsiento = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.numNumeroAsiento = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelPartidas = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpPartidas = new System.Windows.Forms.TableLayoutPanel();
            this.lblPartidasTitulo = new System.Windows.Forms.Label();
            this.dgvPartidas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpCaptura = new System.Windows.Forms.TableLayoutPanel();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.cboCuenta = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.numImporte = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipoPartida = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flpCapturaBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarPartida = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuitarPartida = new Guna.UI2.WinForms.Guna2Button();
            this.tlpTotales = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalDebe = new System.Windows.Forms.Label();
            this.lblTotalHaber = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.tlpPie = new System.Windows.Forms.TableLayoutPanel();
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegistrarAsiento = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevoAsiento = new Guna.UI2.WinForms.Guna2Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.tlpHistorial = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHistorialEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblHistorialTitulo = new System.Windows.Forms.Label();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAsientos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpFondo.SuspendLayout();
            this.tcOperaciones.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.tlpNuevo.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            this.tlpEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroAsiento)).BeginInit();
            this.panelPartidas.SuspendLayout();
            this.tlpPartidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.tlpCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImporte)).BeginInit();
            this.flpCapturaBotones.SuspendLayout();
            this.tlpTotales.SuspendLayout();
            this.tlpPie.SuspendLayout();
            this.flpBotones.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            this.tlpHistorial.SuspendLayout();
            this.tlpHistorialEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFondo
            // 
            this.tlpFondo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tlpFondo.ColumnCount = 1;
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpFondo.Controls.Add(this.tcOperaciones, 0, 1);
            this.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFondo.Location = new System.Drawing.Point(0, 0);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.Padding = new System.Windows.Forms.Padding(15, 8, 15, 16);
            this.tlpFondo.RowCount = 2;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.Size = new System.Drawing.Size(1085, 687);
            this.tlpFondo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(345, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(395, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRAR OPERACIONES";
            // 
            // tcOperaciones
            // 
            this.tcOperaciones.Controls.Add(this.tabNuevo);
            this.tcOperaciones.Controls.Add(this.tabHistorial);
            this.tcOperaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOperaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcOperaciones.ItemSize = new System.Drawing.Size(180, 40);
            this.tcOperaciones.Location = new System.Drawing.Point(18, 54);
            this.tcOperaciones.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tcOperaciones.Name = "tcOperaciones";
            this.tcOperaciones.SelectedIndex = 0;
            this.tcOperaciones.Size = new System.Drawing.Size(1049, 617);
            this.tcOperaciones.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcOperaciones.TabButtonHoverState.FillColor = System.Drawing.Color.Tan;
            this.tcOperaciones.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcOperaciones.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcOperaciones.TabButtonHoverState.InnerColor = System.Drawing.Color.Tan;
            this.tcOperaciones.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcOperaciones.TabButtonIdleState.FillColor = System.Drawing.Color.LavenderBlush;
            this.tcOperaciones.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcOperaciones.TabButtonIdleState.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tcOperaciones.TabButtonIdleState.InnerColor = System.Drawing.Color.LavenderBlush;
            this.tcOperaciones.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcOperaciones.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.tcOperaciones.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcOperaciones.TabButtonSelectedState.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tcOperaciones.TabButtonSelectedState.InnerColor = System.Drawing.Color.SaddleBrown;
            this.tcOperaciones.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcOperaciones.TabIndex = 1;
            this.tcOperaciones.TabMenuBackColor = System.Drawing.Color.LavenderBlush;
            this.tcOperaciones.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabNuevo
            // 
            this.tabNuevo.BackColor = System.Drawing.Color.White;
            this.tabNuevo.Controls.Add(this.tlpNuevo);
            this.tabNuevo.Location = new System.Drawing.Point(4, 44);
            this.tabNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.tabNuevo.Size = new System.Drawing.Size(1041, 569);
            this.tabNuevo.TabIndex = 0;
            this.tabNuevo.Text = "Nuevo Asiento";
            this.tabNuevo.UseVisualStyleBackColor = true;
            // 
            // tlpNuevo
            // 
            this.tlpNuevo.BackColor = System.Drawing.Color.White;
            this.tlpNuevo.ColumnCount = 1;
            this.tlpNuevo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNuevo.Controls.Add(this.panelEncabezado, 0, 0);
            this.tlpNuevo.Controls.Add(this.panelPartidas, 0, 1);
            this.tlpNuevo.Controls.Add(this.tlpPie, 0, 2);
            this.tlpNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNuevo.Location = new System.Drawing.Point(9, 6);
            this.tlpNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNuevo.Name = "tlpNuevo";
            this.tlpNuevo.RowCount = 3;
            this.tlpNuevo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNuevo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNuevo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNuevo.Size = new System.Drawing.Size(1023, 557);
            this.tlpNuevo.TabIndex = 0;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.panelEncabezado.Controls.Add(this.tlpEncabezado);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEncabezado.FillColor = System.Drawing.Color.White;
            this.panelEncabezado.Location = new System.Drawing.Point(3, 3);
            this.panelEncabezado.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Radius = 20;
            this.panelEncabezado.ShadowColor = System.Drawing.Color.Black;
            this.panelEncabezado.Size = new System.Drawing.Size(1017, 94);
            this.panelEncabezado.TabIndex = 0;
            // 
            // tlpEncabezado
            // 
            this.tlpEncabezado.ColumnCount = 4;
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.16353F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.78692F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEncabezado.Controls.Add(this.lblNumeroAsiento, 0, 0);
            this.tlpEncabezado.Controls.Add(this.lblFecha, 1, 0);
            this.tlpEncabezado.Controls.Add(this.lblReferencia, 2, 0);
            this.tlpEncabezado.Controls.Add(this.lblDescripcion, 3, 0);
            this.tlpEncabezado.Controls.Add(this.numNumeroAsiento, 0, 1);
            this.tlpEncabezado.Controls.Add(this.dtpFecha, 1, 1);
            this.tlpEncabezado.Controls.Add(this.txtReferencia, 2, 1);
            this.tlpEncabezado.Controls.Add(this.txtDescripcion, 3, 1);
            this.tlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncabezado.Location = new System.Drawing.Point(0, 0);
            this.tlpEncabezado.Name = "tlpEncabezado";
            this.tlpEncabezado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpEncabezado.RowCount = 2;
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpEncabezado.Size = new System.Drawing.Size(1017, 94);
            this.tlpEncabezado.TabIndex = 0;
            // 
            // lblNumeroAsiento
            // 
            this.lblNumeroAsiento.AutoSize = true;
            this.lblNumeroAsiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumeroAsiento.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAsiento.ForeColor = System.Drawing.Color.Sienna;
            this.lblNumeroAsiento.Location = new System.Drawing.Point(7, 7);
            this.lblNumeroAsiento.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.lblNumeroAsiento.Name = "lblNumeroAsiento";
            this.lblNumeroAsiento.Size = new System.Drawing.Size(147, 16);
            this.lblNumeroAsiento.TabIndex = 0;
            this.lblNumeroAsiento.Text = "Número de asiento:";
            this.lblNumeroAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Sienna;
            this.lblFecha.Location = new System.Drawing.Point(160, 7);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(345, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReferencia.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.Color.Sienna;
            this.lblReferencia.Location = new System.Drawing.Point(511, 7);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(246, 16);
            this.lblReferencia.TabIndex = 2;
            this.lblReferencia.Text = "Referencia / Factura:";
            this.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Sienna;
            this.lblDescripcion.Location = new System.Drawing.Point(763, 7);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(247, 16);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numNumeroAsiento
            // 
            this.numNumeroAsiento.BackColor = System.Drawing.Color.Transparent;
            this.numNumeroAsiento.BorderColor = System.Drawing.Color.Tan;
            this.numNumeroAsiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numNumeroAsiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.numNumeroAsiento.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumeroAsiento.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numNumeroAsiento.Location = new System.Drawing.Point(7, 29);
            this.numNumeroAsiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numNumeroAsiento.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numNumeroAsiento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumeroAsiento.Name = "numNumeroAsiento";
            this.numNumeroAsiento.Size = new System.Drawing.Size(147, 24);
            this.numNumeroAsiento.TabIndex = 4;
            this.numNumeroAsiento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFecha
            // 
            this.dtpFecha.BorderColor = System.Drawing.Color.Tan;
            this.dtpFecha.BorderRadius = 12;
            this.dtpFecha.Checked = true;
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpFecha.FillColor = System.Drawing.Color.White;
            this.dtpFecha.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(160, 29);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(345, 24);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // txtReferencia
            // 
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReferencia.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtReferencia.Location = new System.Drawing.Point(511, 31);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtReferencia.MaxLength = 50;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(246, 22);
            this.txtReferencia.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtDescripcion.Location = new System.Drawing.Point(763, 31);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(247, 22);
            this.txtDescripcion.TabIndex = 7;
            // 
            // panelPartidas
            // 
            this.panelPartidas.BackColor = System.Drawing.Color.Transparent;
            this.panelPartidas.Controls.Add(this.tlpPartidas);
            this.panelPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPartidas.FillColor = System.Drawing.Color.White;
            this.panelPartidas.Location = new System.Drawing.Point(3, 108);
            this.panelPartidas.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.panelPartidas.Name = "panelPartidas";
            this.panelPartidas.Radius = 20;
            this.panelPartidas.ShadowColor = System.Drawing.Color.Black;
            this.panelPartidas.Size = new System.Drawing.Size(1017, 363);
            this.panelPartidas.TabIndex = 1;
            // 
            // tlpPartidas
            // 
            this.tlpPartidas.ColumnCount = 1;
            this.tlpPartidas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPartidas.Controls.Add(this.lblPartidasTitulo, 0, 0);
            this.tlpPartidas.Controls.Add(this.dgvPartidas, 0, 1);
            this.tlpPartidas.Controls.Add(this.tlpCaptura, 0, 2);
            this.tlpPartidas.Controls.Add(this.tlpTotales, 0, 3);
            this.tlpPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPartidas.Location = new System.Drawing.Point(0, 0);
            this.tlpPartidas.Name = "tlpPartidas";
            this.tlpPartidas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpPartidas.RowCount = 4;
            this.tlpPartidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPartidas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPartidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPartidas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPartidas.Size = new System.Drawing.Size(1017, 363);
            this.tlpPartidas.TabIndex = 0;
            // 
            // lblPartidasTitulo
            // 
            this.lblPartidasTitulo.AutoSize = true;
            this.lblPartidasTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidasTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPartidasTitulo.Location = new System.Drawing.Point(7, 7);
            this.lblPartidasTitulo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblPartidasTitulo.Name = "lblPartidasTitulo";
            this.lblPartidasTitulo.Size = new System.Drawing.Size(171, 23);
            this.lblPartidasTitulo.TabIndex = 0;
            this.lblPartidasTitulo.Text = "Partidas del asiento";
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.AllowUserToAddRows = false;
            this.dgvPartidas.AllowUserToDeleteRows = false;
            this.dgvPartidas.AllowUserToResizeRows = false;
            this.dgvPartidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPartidas.ColumnHeadersHeight = 22;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCuenta,
            this.colDebe,
            this.colHaber});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartidas.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPartidas.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPartidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(214)))), ((int)(((byte)(202)))));
            this.dgvPartidas.Location = new System.Drawing.Point(7, 36);
            this.dgvPartidas.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.ReadOnly = true;
            this.dgvPartidas.RowHeadersVisible = false;
            this.dgvPartidas.RowHeadersWidth = 51;
            this.dgvPartidas.RowTemplate.Height = 26;
            this.dgvPartidas.Size = new System.Drawing.Size(1003, 204);
            this.dgvPartidas.TabIndex = 1;
            this.dgvPartidas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(214)))), ((int)(((byte)(202)))));
            this.dgvPartidas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Tan;
            this.dgvPartidas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPartidas.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvPartidas.ThemeStyle.ReadOnly = true;
            this.dgvPartidas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPartidas.ThemeStyle.RowsStyle.Height = 26;
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 15F;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colCuenta
            // 
            this.colCuenta.FillWeight = 45F;
            this.colCuenta.HeaderText = "Cuenta";
            this.colCuenta.MinimumWidth = 6;
            this.colCuenta.Name = "colCuenta";
            this.colCuenta.ReadOnly = true;
            // 
            // colDebe
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            this.colDebe.DefaultCellStyle = dataGridViewCellStyle18;
            this.colDebe.FillWeight = 20F;
            this.colDebe.HeaderText = "Débito";
            this.colDebe.MinimumWidth = 6;
            this.colDebe.Name = "colDebe";
            this.colDebe.ReadOnly = true;
            // 
            // colHaber
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            this.colHaber.DefaultCellStyle = dataGridViewCellStyle19;
            this.colHaber.FillWeight = 20F;
            this.colHaber.HeaderText = "Crédito";
            this.colHaber.MinimumWidth = 6;
            this.colHaber.Name = "colHaber";
            this.colHaber.ReadOnly = true;
            // 
            // tlpCaptura
            // 
            this.tlpCaptura.ColumnCount = 6;
            this.tlpCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpCaptura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCaptura.Controls.Add(this.lblCuenta, 0, 0);
            this.tlpCaptura.Controls.Add(this.cboCuenta, 1, 0);
            this.tlpCaptura.Controls.Add(this.lblImporte, 2, 0);
            this.tlpCaptura.Controls.Add(this.numImporte, 3, 0);
            this.tlpCaptura.Controls.Add(this.lblTipo, 4, 0);
            this.tlpCaptura.Controls.Add(this.cboTipoPartida, 5, 0);
            this.tlpCaptura.Controls.Add(this.flpCapturaBotones, 0, 1);
            this.tlpCaptura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCaptura.Location = new System.Drawing.Point(7, 243);
            this.tlpCaptura.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tlpCaptura.Name = "tlpCaptura";
            this.tlpCaptura.RowCount = 2;
            this.tlpCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpCaptura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpCaptura.Size = new System.Drawing.Size(1003, 78);
            this.tlpCaptura.TabIndex = 2;
            // 
            // lblCuenta
            // 
            this.lblCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuenta.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.ForeColor = System.Drawing.Color.Sienna;
            this.lblCuenta.Location = new System.Drawing.Point(3, 3);
            this.lblCuenta.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(60, 26);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta:";
            this.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCuenta
            // 
            this.cboCuenta.BackColor = System.Drawing.Color.Transparent;
            this.cboCuenta.BorderColor = System.Drawing.Color.Tan;
            this.cboCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FocusedColor = System.Drawing.Color.Sienna;
            this.cboCuenta.FocusedState.BorderColor = System.Drawing.Color.Sienna;
            this.cboCuenta.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuenta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboCuenta.ItemHeight = 30;
            this.cboCuenta.Location = new System.Drawing.Point(74, 3);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(334, 36);
            this.cboCuenta.TabIndex = 3;
            // 
            // lblImporte
            // 
            this.lblImporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImporte.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.Color.Sienna;
            this.lblImporte.Location = new System.Drawing.Point(414, 3);
            this.lblImporte.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(60, 26);
            this.lblImporte.TabIndex = 1;
            this.lblImporte.Text = "Importe:";
            this.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numImporte
            // 
            this.numImporte.BackColor = System.Drawing.Color.Transparent;
            this.numImporte.BorderColor = System.Drawing.Color.Tan;
            this.numImporte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numImporte.DecimalPlaces = 2;
            this.numImporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numImporte.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numImporte.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numImporte.Location = new System.Drawing.Point(485, 3);
            this.numImporte.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numImporte.Name = "numImporte";
            this.numImporte.Size = new System.Drawing.Size(207, 26);
            this.numImporte.TabIndex = 4;
            this.numImporte.ThousandsSeparator = true;
            // 
            // lblTipo
            // 
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Sienna;
            this.lblTipo.Location = new System.Drawing.Point(698, 3);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(83, 26);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Debe / Haber:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipoPartida
            // 
            this.cboTipoPartida.BackColor = System.Drawing.Color.Transparent;
            this.cboTipoPartida.BorderColor = System.Drawing.Color.Tan;
            this.cboTipoPartida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipoPartida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPartida.FocusedColor = System.Drawing.Color.Sienna;
            this.cboTipoPartida.FocusedState.BorderColor = System.Drawing.Color.Sienna;
            this.cboTipoPartida.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPartida.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboTipoPartida.ItemHeight = 30;
            this.cboTipoPartida.Location = new System.Drawing.Point(792, 3);
            this.cboTipoPartida.Name = "cboTipoPartida";
            this.cboTipoPartida.Size = new System.Drawing.Size(208, 36);
            this.cboTipoPartida.TabIndex = 5;
            // 
            // flpCapturaBotones
            // 
            this.tlpCaptura.SetColumnSpan(this.flpCapturaBotones, 6);
            this.flpCapturaBotones.Controls.Add(this.btnAgregarPartida);
            this.flpCapturaBotones.Controls.Add(this.btnQuitarPartida);
            this.flpCapturaBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCapturaBotones.Location = new System.Drawing.Point(0, 35);
            this.flpCapturaBotones.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flpCapturaBotones.Name = "flpCapturaBotones";
            this.flpCapturaBotones.Size = new System.Drawing.Size(1003, 43);
            this.flpCapturaBotones.TabIndex = 6;
            // 
            // btnAgregarPartida
            // 
            this.btnAgregarPartida.BorderRadius = 15;
            this.btnAgregarPartida.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAgregarPartida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPartida.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPartida.Image = global::WindowsFormsApp1.Properties.Resources.assignment_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnAgregarPartida.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAgregarPartida.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarPartida.Name = "btnAgregarPartida";
            this.btnAgregarPartida.Size = new System.Drawing.Size(128, 36);
            this.btnAgregarPartida.TabIndex = 0;
            this.btnAgregarPartida.Text = "Agregar Partida";
            this.btnAgregarPartida.Click += new System.EventHandler(this.btnAgregarPartida_Click);
            // 
            // btnQuitarPartida
            // 
            this.btnQuitarPartida.BorderRadius = 15;
            this.btnQuitarPartida.CustomBorderColor = System.Drawing.Color.Sienna;
            this.btnQuitarPartida.FillColor = System.Drawing.Color.White;
            this.btnQuitarPartida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPartida.ForeColor = System.Drawing.Color.Sienna;
            this.btnQuitarPartida.Image = global::WindowsFormsApp1.Properties.Resources.free_cancellation_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnQuitarPartida.ImageSize = new System.Drawing.Size(22, 22);
            this.btnQuitarPartida.Location = new System.Drawing.Point(137, 3);
            this.btnQuitarPartida.Name = "btnQuitarPartida";
            this.btnQuitarPartida.Size = new System.Drawing.Size(120, 36);
            this.btnQuitarPartida.TabIndex = 1;
            this.btnQuitarPartida.Text = "Quitar Partida";
            this.btnQuitarPartida.Click += new System.EventHandler(this.btnQuitarPartida_Click);
            // 
            // tlpTotales
            // 
            this.tlpTotales.ColumnCount = 3;
            this.tlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTotales.Controls.Add(this.lblTotalDebe, 0, 0);
            this.tlpTotales.Controls.Add(this.lblTotalHaber, 1, 0);
            this.tlpTotales.Controls.Add(this.lblDiferencia, 2, 0);
            this.tlpTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTotales.Location = new System.Drawing.Point(7, 327);
            this.tlpTotales.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.tlpTotales.Name = "tlpTotales";
            this.tlpTotales.RowCount = 1;
            this.tlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotales.Size = new System.Drawing.Size(1003, 32);
            this.tlpTotales.TabIndex = 3;
            // 
            // lblTotalDebe
            // 
            this.lblTotalDebe.AutoSize = true;
            this.lblTotalDebe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDebe.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebe.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDebe.Location = new System.Drawing.Point(3, 3);
            this.lblTotalDebe.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblTotalDebe.Name = "lblTotalDebe";
            this.lblTotalDebe.Size = new System.Drawing.Size(328, 26);
            this.lblTotalDebe.TabIndex = 0;
            this.lblTotalDebe.Text = "Total Debe: 0.00";
            this.lblTotalDebe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalHaber
            // 
            this.lblTotalHaber.AutoSize = true;
            this.lblTotalHaber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalHaber.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHaber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalHaber.Location = new System.Drawing.Point(337, 3);
            this.lblTotalHaber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblTotalHaber.Name = "lblTotalHaber";
            this.lblTotalHaber.Size = new System.Drawing.Size(328, 26);
            this.lblTotalHaber.TabIndex = 1;
            this.lblTotalHaber.Text = "Total Haber: 0.00";
            this.lblTotalHaber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiferencia.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.ForeColor = System.Drawing.Color.Sienna;
            this.lblDiferencia.Location = new System.Drawing.Point(671, 3);
            this.lblDiferencia.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(329, 26);
            this.lblDiferencia.TabIndex = 2;
            this.lblDiferencia.Text = "Diferencia: 0.00";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpPie
            // 
            this.tlpPie.ColumnCount = 1;
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPie.Controls.Add(this.flpBotones, 0, 0);
            this.tlpPie.Controls.Add(this.lblMensaje, 0, 1);
            this.tlpPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPie.Location = new System.Drawing.Point(3, 482);
            this.tlpPie.Name = "tlpPie";
            this.tlpPie.RowCount = 2;
            this.tlpPie.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPie.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPie.Size = new System.Drawing.Size(1017, 72);
            this.tlpPie.TabIndex = 2;
            // 
            // flpBotones
            // 
            this.flpBotones.AutoSize = true;
            this.flpBotones.Controls.Add(this.btnRegistrarAsiento);
            this.flpBotones.Controls.Add(this.btnNuevoAsiento);
            this.flpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotones.Location = new System.Drawing.Point(0, 0);
            this.flpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(1017, 43);
            this.flpBotones.TabIndex = 0;
            this.flpBotones.WrapContents = false;
            // 
            // btnRegistrarAsiento
            // 
            this.btnRegistrarAsiento.BorderRadius = 15;
            this.btnRegistrarAsiento.FillColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarAsiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAsiento.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarAsiento.Image = global::WindowsFormsApp1.Properties.Resources.save_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnRegistrarAsiento.ImageSize = new System.Drawing.Size(22, 22);
            this.btnRegistrarAsiento.Location = new System.Drawing.Point(3, 3);
            this.btnRegistrarAsiento.Name = "btnRegistrarAsiento";
            this.btnRegistrarAsiento.Size = new System.Drawing.Size(142, 37);
            this.btnRegistrarAsiento.TabIndex = 0;
            this.btnRegistrarAsiento.Text = "Registrar Asiento";
            this.btnRegistrarAsiento.Click += new System.EventHandler(this.btnRegistrarAsiento_Click);
            // 
            // btnNuevoAsiento
            // 
            this.btnNuevoAsiento.BorderRadius = 15;
            this.btnNuevoAsiento.FillColor = System.Drawing.Color.Tan;
            this.btnNuevoAsiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAsiento.ForeColor = System.Drawing.Color.White;
            this.btnNuevoAsiento.Image = global::WindowsFormsApp1.Properties.Resources.contract_edit_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnNuevoAsiento.ImageSize = new System.Drawing.Size(22, 22);
            this.btnNuevoAsiento.Location = new System.Drawing.Point(151, 3);
            this.btnNuevoAsiento.Name = "btnNuevoAsiento";
            this.btnNuevoAsiento.Size = new System.Drawing.Size(135, 37);
            this.btnNuevoAsiento.TabIndex = 1;
            this.btnNuevoAsiento.Text = "Nuevo Asiento";
            this.btnNuevoAsiento.Click += new System.EventHandler(this.btnNuevoAsiento_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Sienna;
            this.lblMensaje.Location = new System.Drawing.Point(3, 46);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(1011, 26);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Complete los datos del asiento y agregue las partidas.";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabHistorial
            // 
            this.tabHistorial.BackColor = System.Drawing.Color.White;
            this.tabHistorial.Controls.Add(this.tlpHistorial);
            this.tabHistorial.Location = new System.Drawing.Point(4, 44);
            this.tabHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.tabHistorial.Size = new System.Drawing.Size(1041, 587);
            this.tabHistorial.TabIndex = 1;
            this.tabHistorial.Text = "Asientos Registrados";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // tlpHistorial
            // 
            this.tlpHistorial.BackColor = System.Drawing.Color.White;
            this.tlpHistorial.ColumnCount = 1;
            this.tlpHistorial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHistorial.Controls.Add(this.tlpHistorialEncabezado, 0, 0);
            this.tlpHistorial.Controls.Add(this.dgvAsientos, 0, 1);
            this.tlpHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHistorial.Location = new System.Drawing.Point(9, 6);
            this.tlpHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHistorial.Name = "tlpHistorial";
            this.tlpHistorial.RowCount = 2;
            this.tlpHistorial.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHistorial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHistorial.Size = new System.Drawing.Size(1023, 575);
            this.tlpHistorial.TabIndex = 0;
            // 
            // tlpHistorialEncabezado
            // 
            this.tlpHistorialEncabezado.ColumnCount = 2;
            this.tlpHistorialEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHistorialEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHistorialEncabezado.Controls.Add(this.lblHistorialTitulo, 0, 0);
            this.tlpHistorialEncabezado.Controls.Add(this.btnActualizar, 1, 0);
            this.tlpHistorialEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHistorialEncabezado.Location = new System.Drawing.Point(3, 3);
            this.tlpHistorialEncabezado.Name = "tlpHistorialEncabezado";
            this.tlpHistorialEncabezado.RowCount = 1;
            this.tlpHistorialEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHistorialEncabezado.Size = new System.Drawing.Size(1017, 43);
            this.tlpHistorialEncabezado.TabIndex = 0;
            // 
            // lblHistorialTitulo
            // 
            this.lblHistorialTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHistorialTitulo.AutoSize = true;
            this.lblHistorialTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHistorialTitulo.Location = new System.Drawing.Point(3, 10);
            this.lblHistorialTitulo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblHistorialTitulo.Name = "lblHistorialTitulo";
            this.lblHistorialTitulo.Size = new System.Drawing.Size(178, 23);
            this.lblHistorialTitulo.TabIndex = 0;
            this.lblHistorialTitulo.Text = "Asientos registrados";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BorderRadius = 15;
            this.btnActualizar.CustomBorderColor = System.Drawing.Color.Sienna;
            this.btnActualizar.FillColor = System.Drawing.Color.White;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Sienna;
            this.btnActualizar.Image = global::WindowsFormsApp1.Properties.Resources.manage_search_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnActualizar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnActualizar.Location = new System.Drawing.Point(912, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 37);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvAsientos
            // 
            this.dgvAsientos.AllowUserToAddRows = false;
            this.dgvAsientos.AllowUserToDeleteRows = false;
            this.dgvAsientos.AllowUserToResizeRows = false;
            this.dgvAsientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvAsientos.ColumnHeadersHeight = 22;
            this.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colFecha,
            this.colReferencia,
            this.colDescripcion,
            this.colTotalDebe,
            this.colTotalHaber});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsientos.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvAsientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsientos.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAsientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(214)))), ((int)(((byte)(202)))));
            this.dgvAsientos.Location = new System.Drawing.Point(3, 49);
            this.dgvAsientos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dgvAsientos.Name = "dgvAsientos";
            this.dgvAsientos.ReadOnly = true;
            this.dgvAsientos.RowHeadersVisible = false;
            this.dgvAsientos.RowHeadersWidth = 51;
            this.dgvAsientos.RowTemplate.Height = 26;
            this.dgvAsientos.Size = new System.Drawing.Size(1017, 523);
            this.dgvAsientos.TabIndex = 1;
            this.dgvAsientos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(214)))), ((int)(((byte)(202)))));
            this.dgvAsientos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Tan;
            this.dgvAsientos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAsientos.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvAsientos.ThemeStyle.ReadOnly = true;
            this.dgvAsientos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAsientos.ThemeStyle.RowsStyle.Height = 26;
            // 
            // colNumero
            // 
            this.colNumero.FillWeight = 10F;
            this.colNumero.HeaderText = "Nº";
            this.colNumero.MinimumWidth = 6;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 12F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colReferencia
            // 
            this.colReferencia.FillWeight = 18F;
            this.colReferencia.HeaderText = "Referencia / Factura";
            this.colReferencia.MinimumWidth = 6;
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FillWeight = 35F;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colTotalDebe
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            this.colTotalDebe.DefaultCellStyle = dataGridViewCellStyle22;
            this.colTotalDebe.FillWeight = 12F;
            this.colTotalDebe.HeaderText = "Total Débito";
            this.colTotalDebe.MinimumWidth = 6;
            this.colTotalDebe.Name = "colTotalDebe";
            this.colTotalDebe.ReadOnly = true;
            // 
            // colTotalHaber
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N2";
            this.colTotalHaber.DefaultCellStyle = dataGridViewCellStyle23;
            this.colTotalHaber.FillWeight = 12F;
            this.colTotalHaber.HeaderText = "Total Crédito";
            this.colTotalHaber.MinimumWidth = 6;
            this.colTotalHaber.Name = "colTotalHaber";
            this.colTotalHaber.ReadOnly = true;
            // 
            // FormRegistrarOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 687);
            this.Controls.Add(this.tlpFondo);
            this.Name = "FormRegistrarOperaciones";
            this.Text = "Registrar Operaciones";
            this.Load += new System.EventHandler(this.FormRegistrarOperaciones_Load);
            this.tlpFondo.ResumeLayout(false);
            this.tlpFondo.PerformLayout();
            this.tcOperaciones.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.tlpNuevo.ResumeLayout(false);
            this.panelEncabezado.ResumeLayout(false);
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroAsiento)).EndInit();
            this.panelPartidas.ResumeLayout(false);
            this.tlpPartidas.ResumeLayout(false);
            this.tlpPartidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.tlpCaptura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numImporte)).EndInit();
            this.flpCapturaBotones.ResumeLayout(false);
            this.tlpTotales.ResumeLayout(false);
            this.tlpTotales.PerformLayout();
            this.tlpPie.ResumeLayout(false);
            this.tlpPie.PerformLayout();
            this.flpBotones.ResumeLayout(false);
            this.tabHistorial.ResumeLayout(false);
            this.tlpHistorial.ResumeLayout(false);
            this.tlpHistorialEncabezado.ResumeLayout(false);
            this.tlpHistorialEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TabControl tcOperaciones;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.TableLayoutPanel tlpNuevo;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelEncabezado;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblNumeroAsiento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblDescripcion;
        private Guna.UI2.WinForms.Guna2NumericUpDown numNumeroAsiento;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelPartidas;
        private System.Windows.Forms.TableLayoutPanel tlpPartidas;
        private System.Windows.Forms.Label lblPartidasTitulo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPartidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHaber;
        private System.Windows.Forms.TableLayoutPanel tlpCaptura;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblTipo;
        private Guna.UI2.WinForms.Guna2ComboBox cboCuenta;
        private Guna.UI2.WinForms.Guna2NumericUpDown numImporte;
        private Guna.UI2.WinForms.Guna2ComboBox cboTipoPartida;
        private System.Windows.Forms.FlowLayoutPanel flpCapturaBotones;
        private Guna.UI2.WinForms.Guna2Button btnAgregarPartida;
        private Guna.UI2.WinForms.Guna2Button btnQuitarPartida;
        private System.Windows.Forms.TableLayoutPanel tlpTotales;
        private System.Windows.Forms.Label lblTotalDebe;
        private System.Windows.Forms.Label lblTotalHaber;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.TableLayoutPanel tlpPie;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarAsiento;
        private Guna.UI2.WinForms.Guna2Button btnNuevoAsiento;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TableLayoutPanel tlpHistorial;
        private System.Windows.Forms.TableLayoutPanel tlpHistorialEncabezado;
        private System.Windows.Forms.Label lblHistorialTitulo;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAsientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalHaber;
    }
}
