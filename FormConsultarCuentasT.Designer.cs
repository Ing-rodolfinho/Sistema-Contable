namespace WindowsFormsApp1
{
    partial class FormConsultarCuentasT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle bodyStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle amountStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle headerStyleCuentas = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle bodyStyleCuentas = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpFondo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCuentas = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpCuentas = new System.Windows.Forms.TableLayoutPanel();
            this.lblCuentasTitulo = new System.Windows.Forms.Label();
            this.dgvCuentasLista = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaturaleza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCuentaT = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpCuentaT = new System.Windows.Forms.TableLayoutPanel();
            this.panelBusquedaCuentaT = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.lblCuentaTBuscar = new System.Windows.Forms.Label();
            this.txtCodigoCuenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscarCuentaT = new Guna.UI2.WinForms.Guna2Button();
            this.panelFiltrosFecha = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpFiltrosFecha = new System.Windows.Forms.TableLayoutPanel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.lblCuentaTitulo = new System.Windows.Forms.Label();
            this.lblDebeTitulo = new System.Windows.Forms.Label();
            this.divisorPanel = new System.Windows.Forms.Panel();
            this.lblHaberTitulo = new System.Windows.Forms.Label();
            this.dgvDebe = new System.Windows.Forms.DataGridView();
            this.colDebeFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebeAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebeReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebeConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebeImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHaber = new System.Windows.Forms.DataGridView();
            this.colHaberFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHaberAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHaberReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHaberConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHaberImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDebe = new System.Windows.Forms.Label();
            this.lblTotalHaber = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tlpFondo.SuspendLayout();
            this.panelCuentas.SuspendLayout();
            this.tlpCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasLista)).BeginInit();
            this.panelCuentaT.SuspendLayout();
            this.tlpCuentaT.SuspendLayout();
            this.panelBusquedaCuentaT.SuspendLayout();
            this.tlpBusqueda.SuspendLayout();
            this.panelFiltrosFecha.SuspendLayout();
            this.tlpFiltrosFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaber)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFondo
            // 
            this.tlpFondo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tlpFondo.ColumnCount = 1;
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpFondo.Controls.Add(this.panelCuentas, 0, 1);
            this.tlpFondo.Controls.Add(this.panelCuentaT, 0, 2);
            this.tlpFondo.Controls.Add(this.lblMensaje, 0, 3);
            this.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFondo.Location = new System.Drawing.Point(0, 0);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.RowCount = 4;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFondo.Size = new System.Drawing.Size(1185, 787);
            this.tlpFondo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(397, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(3, 14, 3, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(391, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONSULTAR CUENTAS T";
            // 
            // panelCuentas
            // 
            this.panelCuentas.BackColor = System.Drawing.Color.Transparent;
            this.panelCuentas.Controls.Add(this.tlpCuentas);
            this.panelCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuentas.FillColor = System.Drawing.Color.White;
            this.panelCuentas.Location = new System.Drawing.Point(15, 56);
            this.panelCuentas.Margin = new System.Windows.Forms.Padding(15, 0, 15, 10);
            this.panelCuentas.Name = "panelCuentas";
            this.panelCuentas.Radius = 15;
            this.panelCuentas.ShadowColor = System.Drawing.Color.Black;
            this.panelCuentas.Size = new System.Drawing.Size(1155, 302);
            this.panelCuentas.TabIndex = 1;
            // 
            // tlpCuentas
            // 
            this.tlpCuentas.ColumnCount = 1;
            this.tlpCuentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuentas.Controls.Add(this.lblCuentasTitulo, 0, 0);
            this.tlpCuentas.Controls.Add(this.dgvCuentasLista, 0, 1);
            this.tlpCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCuentas.Location = new System.Drawing.Point(0, 0);
            this.tlpCuentas.Name = "tlpCuentas";
            this.tlpCuentas.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.tlpCuentas.RowCount = 2;
            this.tlpCuentas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCuentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuentas.Size = new System.Drawing.Size(1155, 302);
            this.tlpCuentas.TabIndex = 0;
            // 
            // lblCuentasTitulo
            // 
            this.lblCuentasTitulo.AutoSize = true;
            this.lblCuentasTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuentasTitulo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentasTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCuentasTitulo.Location = new System.Drawing.Point(15, 10);
            this.lblCuentasTitulo.Name = "lblCuentasTitulo";
            this.lblCuentasTitulo.Size = new System.Drawing.Size(1125, 22);
            this.lblCuentasTitulo.TabIndex = 0;
            this.lblCuentasTitulo.Text = "Cuentas registradas";
            this.lblCuentasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCuentasLista
            // 
            this.dgvCuentasLista.AllowUserToAddRows = false;
            this.dgvCuentasLista.AllowUserToDeleteRows = false;
            this.dgvCuentasLista.AllowUserToResizeRows = false;
            this.dgvCuentasLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvCuentasLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentasLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            headerStyleCuentas.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyleCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            headerStyleCuentas.ForeColor = System.Drawing.Color.SaddleBrown;
            headerStyleCuentas.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            headerStyleCuentas.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            headerStyleCuentas.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentasLista.ColumnHeadersDefaultCellStyle = headerStyleCuentas;
            this.dgvCuentasLista.ColumnHeadersHeight = 30;
            this.dgvCuentasLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTipo,
            this.colNaturaleza,
            this.colEstado});
            bodyStyleCuentas.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            bodyStyleCuentas.BackColor = System.Drawing.SystemColors.Window;
            bodyStyleCuentas.ForeColor = System.Drawing.Color.SaddleBrown;
            bodyStyleCuentas.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            bodyStyleCuentas.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            bodyStyleCuentas.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentasLista.DefaultCellStyle = bodyStyleCuentas;
            this.dgvCuentasLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuentasLista.EnableHeadersVisualStyles = false;
            this.dgvCuentasLista.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCuentasLista.Location = new System.Drawing.Point(15, 45);
            this.dgvCuentasLista.MultiSelect = false;
            this.dgvCuentasLista.Name = "dgvCuentasLista";
            this.dgvCuentasLista.ReadOnly = true;
            this.dgvCuentasLista.RowHeadersVisible = false;
            this.dgvCuentasLista.RowTemplate.Height = 24;
            this.dgvCuentasLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasLista.Size = new System.Drawing.Size(1125, 237);
            this.dgvCuentasLista.TabIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 90;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 170;
            // 
            // colNaturaleza
            // 
            this.colNaturaleza.HeaderText = "Naturaleza";
            this.colNaturaleza.Name = "colNaturaleza";
            this.colNaturaleza.ReadOnly = true;
            this.colNaturaleza.Width = 120;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 110;
            // 
            // panelCuentaT
            // 
            this.panelCuentaT.BackColor = System.Drawing.Color.Transparent;
            this.panelCuentaT.Controls.Add(this.tlpCuentaT);
            this.panelCuentaT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuentaT.FillColor = System.Drawing.Color.White;
            this.panelCuentaT.Location = new System.Drawing.Point(15, 378);
            this.panelCuentaT.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelCuentaT.Name = "panelCuentaT";
            this.panelCuentaT.Radius = 20;
            this.panelCuentaT.ShadowColor = System.Drawing.Color.Black;
            this.panelCuentaT.Size = new System.Drawing.Size(1155, 363);
            this.panelCuentaT.TabIndex = 2;
            // 
            // tlpCuentaT
            // 
            this.tlpCuentaT.ColumnCount = 3;
            this.tlpCuentaT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCuentaT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpCuentaT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCuentaT.Controls.Add(this.panelBusquedaCuentaT, 0, 0);
            this.tlpCuentaT.Controls.Add(this.panelFiltrosFecha, 1, 0);
            this.tlpCuentaT.Controls.Add(this.lblCuentaTitulo, 0, 1);
            this.tlpCuentaT.Controls.Add(this.lblDebeTitulo, 0, 2);
            this.tlpCuentaT.Controls.Add(this.divisorPanel, 1, 2);
            this.tlpCuentaT.Controls.Add(this.lblHaberTitulo, 2, 2);
            this.tlpCuentaT.Controls.Add(this.dgvDebe, 0, 3);
            this.tlpCuentaT.Controls.Add(this.dgvHaber, 2, 3);
            this.tlpCuentaT.Controls.Add(this.lblTotalDebe, 0, 4);
            this.tlpCuentaT.Controls.Add(this.lblTotalHaber, 2, 4);
            this.tlpCuentaT.Controls.Add(this.lblResultado, 0, 5);
            this.tlpCuentaT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCuentaT.Location = new System.Drawing.Point(0, 0);
            this.tlpCuentaT.Name = "tlpCuentaT";
            this.tlpCuentaT.Padding = new System.Windows.Forms.Padding(14, 10, 14, 12);
            this.tlpCuentaT.RowCount = 6;
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCuentaT.SetColumnSpan(this.panelBusquedaCuentaT, 2);
            this.tlpCuentaT.SetColumnSpan(this.lblCuentaTitulo, 3);
            this.tlpCuentaT.SetColumnSpan(this.lblResultado, 3);
            this.tlpCuentaT.SetRowSpan(this.divisorPanel, 4);
            this.tlpCuentaT.Size = new System.Drawing.Size(1155, 363);
            this.tlpCuentaT.TabIndex = 0;
            // 
            // panelBusquedaCuentaT
            // 
            this.panelBusquedaCuentaT.BackColor = System.Drawing.Color.Transparent;
            this.panelBusquedaCuentaT.Controls.Add(this.tlpBusqueda);
            this.panelBusquedaCuentaT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusquedaCuentaT.FillColor = System.Drawing.Color.White;
            this.panelBusquedaCuentaT.Location = new System.Drawing.Point(17, 13);
            this.panelBusquedaCuentaT.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.panelBusquedaCuentaT.Name = "panelBusquedaCuentaT";
            this.panelBusquedaCuentaT.Radius = 10;
            this.panelBusquedaCuentaT.Size = new System.Drawing.Size(539, 48);
            this.panelBusquedaCuentaT.TabIndex = 0;
            // 
            // tlpBusqueda
            // 
            this.tlpBusqueda.ColumnCount = 3;
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBusqueda.Controls.Add(this.lblCuentaTBuscar, 0, 0);
            this.tlpBusqueda.Controls.Add(this.txtCodigoCuenta, 1, 0);
            this.tlpBusqueda.Controls.Add(this.btnBuscarCuentaT, 2, 0);
            this.tlpBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.tlpBusqueda.RowCount = 1;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBusqueda.Size = new System.Drawing.Size(539, 48);
            this.tlpBusqueda.TabIndex = 0;
            // 
            // lblCuentaTBuscar
            // 
            this.lblCuentaTBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuentaTBuscar.AutoSize = true;
            this.lblCuentaTBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaTBuscar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCuentaTBuscar.Location = new System.Drawing.Point(13, 15);
            this.lblCuentaTBuscar.Name = "lblCuentaTBuscar";
            this.lblCuentaTBuscar.Size = new System.Drawing.Size(76, 18);
            this.lblCuentaTBuscar.TabIndex = 0;
            this.lblCuentaTBuscar.Text = "Cuenta T:";
            // 
            // txtCodigoCuenta
            // 
            this.txtCodigoCuenta.BorderColor = System.Drawing.Color.Tan;
            this.txtCodigoCuenta.BorderRadius = 8;
            this.txtCodigoCuenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoCuenta.DefaultText = "";
            this.txtCodigoCuenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoCuenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoCuenta.FocusedState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtCodigoCuenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoCuenta.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtCodigoCuenta.Location = new System.Drawing.Point(100, 9);
            this.txtCodigoCuenta.Margin = new System.Windows.Forms.Padding(8, 3, 10, 3);
            this.txtCodigoCuenta.Name = "txtCodigoCuenta";
            this.txtCodigoCuenta.PasswordChar = '\0';
            this.txtCodigoCuenta.PlaceholderText = "Ingrese código de cuenta";
            this.txtCodigoCuenta.SelectedText = "";
            this.txtCodigoCuenta.Size = new System.Drawing.Size(304, 30);
            this.txtCodigoCuenta.TabIndex = 1;
            this.txtCodigoCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoCuenta_KeyDown);
            // 
            // btnBuscarCuentaT
            // 
            this.btnBuscarCuentaT.BorderRadius = 8;
            this.btnBuscarCuentaT.FillColor = System.Drawing.Color.SaddleBrown;
            this.btnBuscarCuentaT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCuentaT.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCuentaT.Location = new System.Drawing.Point(417, 8);
            this.btnBuscarCuentaT.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.btnBuscarCuentaT.Name = "btnBuscarCuentaT";
            this.btnBuscarCuentaT.Size = new System.Drawing.Size(109, 32);
            this.btnBuscarCuentaT.TabIndex = 2;
            this.btnBuscarCuentaT.Text = "Buscar";
            this.btnBuscarCuentaT.Click += new System.EventHandler(this.btnBuscarCuentaT_Click);
            // 
            // panelFiltrosFecha
            // 
            this.panelFiltrosFecha.BackColor = System.Drawing.Color.Transparent;
            this.panelFiltrosFecha.Controls.Add(this.tlpFiltrosFecha);
            this.panelFiltrosFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiltrosFecha.FillColor = System.Drawing.Color.White;
            this.panelFiltrosFecha.Location = new System.Drawing.Point(562, 13);
            this.panelFiltrosFecha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tlpCuentaT.SetColumnSpan(this.panelFiltrosFecha, 2);
            this.panelFiltrosFecha.Name = "panelFiltrosFecha";
            this.panelFiltrosFecha.Radius = 10;
            this.panelFiltrosFecha.Size = new System.Drawing.Size(576, 48);
            this.panelFiltrosFecha.TabIndex = 1;
            // 
            // tlpFiltrosFecha
            // 
            this.tlpFiltrosFecha.ColumnCount = 7;
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpFiltrosFecha.Controls.Add(this.lblDesde, 0, 0);
            this.tlpFiltrosFecha.Controls.Add(this.dtpDesde, 1, 0);
            this.tlpFiltrosFecha.Controls.Add(this.lblHasta, 2, 0);
            this.tlpFiltrosFecha.Controls.Add(this.dtpHasta, 3, 0);
            this.tlpFiltrosFecha.Controls.Add(this.btnConsultar, 6, 0);
            this.tlpFiltrosFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltrosFecha.Location = new System.Drawing.Point(0, 0);
            this.tlpFiltrosFecha.Name = "tlpFiltrosFecha";
            this.tlpFiltrosFecha.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.tlpFiltrosFecha.RowCount = 1;
            this.tlpFiltrosFecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltrosFecha.Size = new System.Drawing.Size(576, 48);
            this.tlpFiltrosFecha.TabIndex = 0;
            // 
            // lblDesde
            // 
            this.lblDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDesde.Location = new System.Drawing.Point(13, 15);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 18);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.BorderColor = System.Drawing.Color.Tan;
            this.dtpDesde.BorderRadius = 8;
            this.dtpDesde.Checked = true;
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.FillColor = System.Drawing.Color.White;
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(70, 9);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(6, 3, 10, 3);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(116, 30);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpFiltro_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHasta.Location = new System.Drawing.Point(199, 15);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(45, 18);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.BorderColor = System.Drawing.Color.Tan;
            this.dtpHasta.BorderRadius = 8;
            this.dtpHasta.Checked = true;
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.FillColor = System.Drawing.Color.White;
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(253, 9);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(6, 3, 10, 3);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(116, 30);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.Value = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpFiltro_ValueChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BorderRadius = 8;
            this.btnConsultar.FillColor = System.Drawing.Color.SaddleBrown;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(454, 9);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(109, 30);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCuentaTitulo
            // 
            this.lblCuentaTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuentaTitulo.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCuentaTitulo.Location = new System.Drawing.Point(17, 70);
            this.lblCuentaTitulo.Name = "lblCuentaTitulo";
            this.lblCuentaTitulo.Size = new System.Drawing.Size(1121, 30);
            this.lblCuentaTitulo.TabIndex = 2;
            this.lblCuentaTitulo.Text = "CUENTA T";
            this.lblCuentaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDebeTitulo
            // 
            this.lblDebeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.lblDebeTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDebeTitulo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebeTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDebeTitulo.Location = new System.Drawing.Point(17, 104);
            this.lblDebeTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.lblDebeTitulo.Name = "lblDebeTitulo";
            this.lblDebeTitulo.Size = new System.Drawing.Size(555, 28);
            this.lblDebeTitulo.TabIndex = 3;
            this.lblDebeTitulo.Text = "DEBE";
            this.lblDebeTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisorPanel
            // 
            this.divisorPanel.BackColor = System.Drawing.Color.Tan;
            this.divisorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisorPanel.Location = new System.Drawing.Point(578, 105);
            this.divisorPanel.Name = "divisorPanel";
            this.divisorPanel.Size = new System.Drawing.Size(12, 214);
            this.divisorPanel.TabIndex = 4;
            // 
            // lblHaberTitulo
            // 
            this.lblHaberTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.lblHaberTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHaberTitulo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaberTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHaberTitulo.Location = new System.Drawing.Point(596, 104);
            this.lblHaberTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.lblHaberTitulo.Name = "lblHaberTitulo";
            this.lblHaberTitulo.Size = new System.Drawing.Size(539, 28);
            this.lblHaberTitulo.TabIndex = 5;
            this.lblHaberTitulo.Text = "HABER";
            this.lblHaberTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDebe
            // 
            this.dgvDebe.AllowUserToAddRows = false;
            this.dgvDebe.AllowUserToDeleteRows = false;
            this.dgvDebe.AllowUserToResizeRows = false;
            this.dgvDebe.BackgroundColor = System.Drawing.Color.White;
            this.dgvDebe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDebe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            headerStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            headerStyle.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebe.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvDebe.ColumnHeadersHeight = 30;
            this.dgvDebe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDebeFecha,
            this.colDebeAsiento,
            this.colDebeReferencia,
            this.colDebeConcepto,
            this.colDebeImporte});
            bodyStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            bodyStyle.BackColor = System.Drawing.SystemColors.Window;
            bodyStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            bodyStyle.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            bodyStyle.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            bodyStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebe.DefaultCellStyle = bodyStyle;
            this.dgvDebe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebe.EnableHeadersVisualStyles = false;
            this.dgvDebe.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDebe.Location = new System.Drawing.Point(17, 137);
            this.dgvDebe.MultiSelect = false;
            this.dgvDebe.Name = "dgvDebe";
            this.dgvDebe.ReadOnly = true;
            this.dgvDebe.RowHeadersVisible = false;
            this.dgvDebe.RowTemplate.Height = 24;
            this.dgvDebe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebe.Size = new System.Drawing.Size(555, 154);
            this.dgvDebe.TabIndex = 6;
            // 
            // colDebeFecha
            // 
            this.colDebeFecha.HeaderText = "Fecha";
            this.colDebeFecha.Name = "colDebeFecha";
            this.colDebeFecha.ReadOnly = true;
            this.colDebeFecha.Width = 78;
            // 
            // colDebeAsiento
            // 
            this.colDebeAsiento.HeaderText = "N°";
            this.colDebeAsiento.Name = "colDebeAsiento";
            this.colDebeAsiento.ReadOnly = true;
            this.colDebeAsiento.Width = 42;
            // 
            // colDebeReferencia
            // 
            this.colDebeReferencia.HeaderText = "Referencia";
            this.colDebeReferencia.Name = "colDebeReferencia";
            this.colDebeReferencia.ReadOnly = true;
            this.colDebeReferencia.Width = 86;
            // 
            // colDebeConcepto
            // 
            this.colDebeConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDebeConcepto.HeaderText = "Concepto";
            this.colDebeConcepto.MinimumWidth = 80;
            this.colDebeConcepto.Name = "colDebeConcepto";
            this.colDebeConcepto.ReadOnly = true;
            // 
            // colDebeImporte
            // 
            amountStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            amountStyle.Format = "N2";
            this.colDebeImporte.DefaultCellStyle = amountStyle;
            this.colDebeImporte.HeaderText = "Importe";
            this.colDebeImporte.Name = "colDebeImporte";
            this.colDebeImporte.ReadOnly = true;
            this.colDebeImporte.Width = 100;
            // 
            // dgvHaber
            // 
            this.dgvHaber.AllowUserToAddRows = false;
            this.dgvHaber.AllowUserToDeleteRows = false;
            this.dgvHaber.AllowUserToResizeRows = false;
            this.dgvHaber.BackgroundColor = System.Drawing.Color.White;
            this.dgvHaber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHaber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHaber.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvHaber.ColumnHeadersHeight = 30;
            this.dgvHaber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHaberFecha,
            this.colHaberAsiento,
            this.colHaberReferencia,
            this.colHaberConcepto,
            this.colHaberImporte});
            this.dgvHaber.DefaultCellStyle = bodyStyle;
            this.dgvHaber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHaber.EnableHeadersVisualStyles = false;
            this.dgvHaber.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHaber.Location = new System.Drawing.Point(596, 137);
            this.dgvHaber.MultiSelect = false;
            this.dgvHaber.Name = "dgvHaber";
            this.dgvHaber.ReadOnly = true;
            this.dgvHaber.RowHeadersVisible = false;
            this.dgvHaber.RowTemplate.Height = 24;
            this.dgvHaber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHaber.Size = new System.Drawing.Size(539, 154);
            this.dgvHaber.TabIndex = 7;
            // 
            // colHaberFecha
            // 
            this.colHaberFecha.HeaderText = "Fecha";
            this.colHaberFecha.Name = "colHaberFecha";
            this.colHaberFecha.ReadOnly = true;
            this.colHaberFecha.Width = 78;
            // 
            // colHaberAsiento
            // 
            this.colHaberAsiento.HeaderText = "N°";
            this.colHaberAsiento.Name = "colHaberAsiento";
            this.colHaberAsiento.ReadOnly = true;
            this.colHaberAsiento.Width = 42;
            // 
            // colHaberReferencia
            // 
            this.colHaberReferencia.HeaderText = "Referencia";
            this.colHaberReferencia.Name = "colHaberReferencia";
            this.colHaberReferencia.ReadOnly = true;
            this.colHaberReferencia.Width = 86;
            // 
            // colHaberConcepto
            // 
            this.colHaberConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHaberConcepto.HeaderText = "Concepto";
            this.colHaberConcepto.MinimumWidth = 80;
            this.colHaberConcepto.Name = "colHaberConcepto";
            this.colHaberConcepto.ReadOnly = true;
            // 
            // colHaberImporte
            // 
            this.colHaberImporte.DefaultCellStyle = amountStyle;
            this.colHaberImporte.HeaderText = "Importe";
            this.colHaberImporte.Name = "colHaberImporte";
            this.colHaberImporte.ReadOnly = true;
            this.colHaberImporte.Width = 100;
            // 
            // lblTotalDebe
            // 
            this.lblTotalDebe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebe.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDebe.Location = new System.Drawing.Point(17, 300);
            this.lblTotalDebe.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.lblTotalDebe.Name = "lblTotalDebe";
            this.lblTotalDebe.Size = new System.Drawing.Size(555, 20);
            this.lblTotalDebe.TabIndex = 8;
            this.lblTotalDebe.Text = "Total Debe: $ 0.00";
            this.lblTotalDebe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalHaber
            // 
            this.lblTotalHaber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHaber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalHaber.Location = new System.Drawing.Point(596, 300);
            this.lblTotalHaber.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.lblTotalHaber.Name = "lblTotalHaber";
            this.lblTotalHaber.Size = new System.Drawing.Size(539, 20);
            this.lblTotalHaber.TabIndex = 9;
            this.lblTotalHaber.Text = "Total Haber: $ 0.00";
            this.lblTotalHaber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultado
            // 
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblResultado.Location = new System.Drawing.Point(17, 327);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(1121, 24);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "SALDO FINAL: $ 0.00";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblMensaje.Location = new System.Drawing.Point(18, 757);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(18, 3, 3, 10);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 3;
            // 
            // FormConsultarCuentasT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 787);
            this.Controls.Add(this.tlpFondo);
            this.Name = "FormConsultarCuentasT";
            this.Text = "Consultar Cuentas T";
            this.Load += new System.EventHandler(this.FormConsultarCuentasT_Load);
            this.tlpFondo.ResumeLayout(false);
            this.tlpFondo.PerformLayout();
            this.panelCuentas.ResumeLayout(false);
            this.tlpCuentas.ResumeLayout(false);
            this.tlpCuentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasLista)).EndInit();
            this.panelCuentaT.ResumeLayout(false);
            this.tlpCuentaT.ResumeLayout(false);
            this.tlpCuentaT.PerformLayout();
            this.panelBusquedaCuentaT.ResumeLayout(false);
            this.tlpBusqueda.ResumeLayout(false);
            this.tlpBusqueda.PerformLayout();
            this.panelFiltrosFecha.ResumeLayout(false);
            this.tlpFiltrosFecha.ResumeLayout(false);
            this.tlpFiltrosFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelCuentas;
        private System.Windows.Forms.TableLayoutPanel tlpCuentas;
        private System.Windows.Forms.Label lblCuentasTitulo;
        private System.Windows.Forms.DataGridView dgvCuentasLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaturaleza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelCuentaT;
        private System.Windows.Forms.TableLayoutPanel tlpCuentaT;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelBusquedaCuentaT;
        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;
        private System.Windows.Forms.Label lblCuentaTBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoCuenta;
        private Guna.UI2.WinForms.Guna2Button btnBuscarCuentaT;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelFiltrosFecha;
        private System.Windows.Forms.TableLayoutPanel tlpFiltrosFecha;
        private System.Windows.Forms.Label lblDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private System.Windows.Forms.Label lblCuentaTitulo;
        private System.Windows.Forms.Label lblDebeTitulo;
        private System.Windows.Forms.Panel divisorPanel;
        private System.Windows.Forms.Label lblHaberTitulo;
        private System.Windows.Forms.DataGridView dgvDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebeFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebeAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebeReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebeConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebeImporte;
        private System.Windows.Forms.DataGridView dgvHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHaberFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHaberAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHaberReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHaberConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHaberImporte;
        private System.Windows.Forms.Label lblTotalDebe;
        private System.Windows.Forms.Label lblTotalHaber;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblMensaje;
    }
}
