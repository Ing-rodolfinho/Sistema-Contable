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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpFondo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCuentas = new System.Windows.Forms.Panel();
            this.tlpCuentas = new System.Windows.Forms.TableLayoutPanel();
            this.lblCuentasTitulo = new System.Windows.Forms.Label();
            this.dgvCuentasLista = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaturaleza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCuentaT = new System.Windows.Forms.Panel();
            this.tlpCuentaT = new System.Windows.Forms.TableLayoutPanel();
            this.panelBusquedaCuentaT = new System.Windows.Forms.Panel();
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.lblCuentaTBuscar = new System.Windows.Forms.Label();
            this.txtCodigoCuenta = new System.Windows.Forms.TextBox();
            this.btnBuscarCuentaT = new System.Windows.Forms.Button();
            this.panelFiltrosFecha = new System.Windows.Forms.Panel();
            this.tlpFiltrosFecha = new System.Windows.Forms.TableLayoutPanel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
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
            this.tlpFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.RowCount = 4;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpFondo.Size = new System.Drawing.Size(1580, 969);
            this.tlpFondo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(604, 17);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 17, 4, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(371, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONSULTAR CUENTAS T";
            // 
            // panelCuentas
            // 
            this.panelCuentas.BackColor = System.Drawing.Color.White;
            this.panelCuentas.Controls.Add(this.tlpCuentas);
            this.panelCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuentas.Location = new System.Drawing.Point(20, 62);
            this.panelCuentas.Margin = new System.Windows.Forms.Padding(20, 0, 20, 12);
            this.panelCuentas.Name = "panelCuentas";
            this.panelCuentas.Size = new System.Drawing.Size(1540, 301);
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
            this.tlpCuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpCuentas.Name = "tlpCuentas";
            this.tlpCuentas.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.tlpCuentas.RowCount = 2;
            this.tlpCuentas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCuentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuentas.Size = new System.Drawing.Size(1540, 301);
            this.tlpCuentas.TabIndex = 0;
            // 
            // lblCuentasTitulo
            // 
            this.lblCuentasTitulo.AutoSize = true;
            this.lblCuentasTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuentasTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentasTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCuentasTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblCuentasTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuentasTitulo.Name = "lblCuentasTitulo";
            this.lblCuentasTitulo.Size = new System.Drawing.Size(1500, 28);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentasLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentasLista.ColumnHeadersHeight = 30;
            this.dgvCuentasLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTipo,
            this.colNaturaleza,
            this.colEstado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentasLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentasLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuentasLista.EnableHeadersVisualStyles = false;
            this.dgvCuentasLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCuentasLista.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCuentasLista.Location = new System.Drawing.Point(20, 44);
            this.dgvCuentasLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCuentasLista.MultiSelect = false;
            this.dgvCuentasLista.Name = "dgvCuentasLista";
            this.dgvCuentasLista.ReadOnly = true;
            this.dgvCuentasLista.RowHeadersVisible = false;
            this.dgvCuentasLista.RowHeadersWidth = 51;
            this.dgvCuentasLista.RowTemplate.Height = 24;
            this.dgvCuentasLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasLista.Size = new System.Drawing.Size(1500, 241);
            this.dgvCuentasLista.TabIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 90;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 170;
            // 
            // colNaturaleza
            // 
            this.colNaturaleza.HeaderText = "Naturaleza";
            this.colNaturaleza.MinimumWidth = 6;
            this.colNaturaleza.Name = "colNaturaleza";
            this.colNaturaleza.ReadOnly = true;
            this.colNaturaleza.Width = 120;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 110;
            // 
            // panelCuentaT
            // 
            this.panelCuentaT.BackColor = System.Drawing.Color.White;
            this.panelCuentaT.Controls.Add(this.tlpCuentaT);
            this.panelCuentaT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuentaT.Location = new System.Drawing.Point(20, 387);
            this.panelCuentaT.Margin = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.panelCuentaT.Name = "panelCuentaT";
            this.panelCuentaT.Size = new System.Drawing.Size(1540, 532);
            this.panelCuentaT.TabIndex = 2;
            // 
            // tlpCuentaT
            // 
            this.tlpCuentaT.ColumnCount = 3;
            this.tlpCuentaT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCuentaT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCuentaT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCuentaT.Controls.Add(this.panelBusquedaCuentaT, 0, 0);
            this.tlpCuentaT.Controls.Add(this.panelFiltrosFecha, 2, 0);
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
            this.tlpCuentaT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpCuentaT.Name = "tlpCuentaT";
            this.tlpCuentaT.Padding = new System.Windows.Forms.Padding(19, 12, 19, 15);
            this.tlpCuentaT.RowCount = 6;
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpCuentaT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpCuentaT.Size = new System.Drawing.Size(1540, 532);
            this.tlpCuentaT.TabIndex = 0;
            // 
            // panelBusquedaCuentaT
            // 
            this.panelBusquedaCuentaT.BackColor = System.Drawing.Color.White;
            this.panelBusquedaCuentaT.Controls.Add(this.tlpBusqueda);
            this.panelBusquedaCuentaT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusquedaCuentaT.Location = new System.Drawing.Point(23, 16);
            this.panelBusquedaCuentaT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.panelBusquedaCuentaT.Name = "panelBusquedaCuentaT";
            this.panelBusquedaCuentaT.Size = new System.Drawing.Size(731, 59);
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
            this.tlpBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.Padding = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.tlpBusqueda.RowCount = 1;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBusqueda.Size = new System.Drawing.Size(731, 59);
            this.tlpBusqueda.TabIndex = 0;
            // 
            // lblCuentaTBuscar
            // 
            this.lblCuentaTBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuentaTBuscar.AutoSize = true;
            this.lblCuentaTBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaTBuscar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCuentaTBuscar.Location = new System.Drawing.Point(17, 18);
            this.lblCuentaTBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuentaTBuscar.Name = "lblCuentaTBuscar";
            this.lblCuentaTBuscar.Size = new System.Drawing.Size(83, 23);
            this.lblCuentaTBuscar.TabIndex = 0;
            this.lblCuentaTBuscar.Text = "Cuenta T:";
            // 
            // txtCodigoCuenta
            // 
            this.txtCodigoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoCuenta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigoCuenta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCodigoCuenta.Location = new System.Drawing.Point(115, 11);
            this.txtCodigoCuenta.Margin = new System.Windows.Forms.Padding(11, 4, 13, 4);
            this.txtCodigoCuenta.MaxLength = 20;
            this.txtCodigoCuenta.Name = "txtCodigoCuenta";
            this.txtCodigoCuenta.Size = new System.Drawing.Size(441, 30);
            this.txtCodigoCuenta.TabIndex = 1;
            this.txtCodigoCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoCuenta_KeyDown);
            // 
            // btnBuscarCuentaT
            // 
            this.btnBuscarCuentaT.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBuscarCuentaT.FlatAppearance.BorderSize = 0;
            this.btnBuscarCuentaT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCuentaT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCuentaT.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCuentaT.Location = new System.Drawing.Point(573, 9);
            this.btnBuscarCuentaT.Margin = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.btnBuscarCuentaT.Name = "btnBuscarCuentaT";
            this.btnBuscarCuentaT.Size = new System.Drawing.Size(145, 39);
            this.btnBuscarCuentaT.TabIndex = 2;
            this.btnBuscarCuentaT.Text = "Buscar";
            this.btnBuscarCuentaT.UseVisualStyleBackColor = false;
            this.btnBuscarCuentaT.Click += new System.EventHandler(this.btnBuscarCuentaT_Click);
            // 
            // panelFiltrosFecha
            // 
            this.panelFiltrosFecha.BackColor = System.Drawing.Color.White;
            this.panelFiltrosFecha.Controls.Add(this.tlpFiltrosFecha);
            this.panelFiltrosFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiltrosFecha.Location = new System.Drawing.Point(786, 16);
            this.panelFiltrosFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.panelFiltrosFecha.MinimumSize = new System.Drawing.Size(0, 59);
            this.panelFiltrosFecha.Name = "panelFiltrosFecha";
            this.panelFiltrosFecha.Size = new System.Drawing.Size(731, 59);
            this.panelFiltrosFecha.TabIndex = 1;
            // 
            // tlpFiltrosFecha
            // 
            this.tlpFiltrosFecha.ColumnCount = 5;
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpFiltrosFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltrosFecha.Controls.Add(this.lblDesde, 0, 0);
            this.tlpFiltrosFecha.Controls.Add(this.dtpDesde, 1, 0);
            this.tlpFiltrosFecha.Controls.Add(this.lblHasta, 2, 0);
            this.tlpFiltrosFecha.Controls.Add(this.dtpHasta, 3, 0);
            this.tlpFiltrosFecha.Controls.Add(this.btnConsultar, 4, 0);
            this.tlpFiltrosFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltrosFecha.Location = new System.Drawing.Point(0, 0);
            this.tlpFiltrosFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpFiltrosFecha.Name = "tlpFiltrosFecha";
            this.tlpFiltrosFecha.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.tlpFiltrosFecha.RowCount = 1;
            this.tlpFiltrosFecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpFiltrosFecha.Size = new System.Drawing.Size(731, 59);
            this.tlpFiltrosFecha.TabIndex = 0;
            // 
            // lblDesde
            // 
            this.lblDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDesde.Location = new System.Drawing.Point(12, 18);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(61, 23);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(80, 8);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(133, 30);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpFiltro_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHasta.Location = new System.Drawing.Point(220, 18);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(57, 23);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(284, 8);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(133, 30);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.Value = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpFiltro_ValueChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConsultar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(578, 13);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(145, 34);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCuentaTitulo
            // 
            this.lblCuentaTitulo.AutoEllipsis = true;
            this.tlpCuentaT.SetColumnSpan(this.lblCuentaTitulo, 3);
            this.lblCuentaTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuentaTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCuentaTitulo.Location = new System.Drawing.Point(23, 82);
            this.lblCuentaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuentaTitulo.Name = "lblCuentaTitulo";
            this.lblCuentaTitulo.Size = new System.Drawing.Size(1494, 34);
            this.lblCuentaTitulo.TabIndex = 2;
            this.lblCuentaTitulo.Text = "CUENTA T";
            this.lblCuentaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDebeTitulo
            // 
            this.lblDebeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.lblDebeTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDebeTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebeTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDebeTitulo.Location = new System.Drawing.Point(23, 121);
            this.lblDebeTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 2);
            this.lblDebeTitulo.Name = "lblDebeTitulo";
            this.lblDebeTitulo.Size = new System.Drawing.Size(731, 27);
            this.lblDebeTitulo.TabIndex = 3;
            this.lblDebeTitulo.Text = "DEBE";
            this.lblDebeTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisorPanel
            // 
            this.divisorPanel.BackColor = System.Drawing.Color.Tan;
            this.divisorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisorPanel.Location = new System.Drawing.Point(762, 120);
            this.divisorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divisorPanel.Name = "divisorPanel";
            this.tlpCuentaT.SetRowSpan(this.divisorPanel, 3);
            this.divisorPanel.Size = new System.Drawing.Size(16, 360);
            this.divisorPanel.TabIndex = 4;
            // 
            // lblHaberTitulo
            // 
            this.lblHaberTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.lblHaberTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHaberTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaberTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHaberTitulo.Location = new System.Drawing.Point(786, 121);
            this.lblHaberTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 2);
            this.lblHaberTitulo.Name = "lblHaberTitulo";
            this.lblHaberTitulo.Size = new System.Drawing.Size(731, 27);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDebe.ColumnHeadersHeight = 30;
            this.dgvDebe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDebeFecha,
            this.colDebeAsiento,
            this.colDebeReferencia,
            this.colDebeConcepto,
            this.colDebeImporte});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebe.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDebe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebe.EnableHeadersVisualStyles = false;
            this.dgvDebe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDebe.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDebe.Location = new System.Drawing.Point(23, 154);
            this.dgvDebe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDebe.MultiSelect = false;
            this.dgvDebe.Name = "dgvDebe";
            this.dgvDebe.ReadOnly = true;
            this.dgvDebe.RowHeadersVisible = false;
            this.dgvDebe.RowHeadersWidth = 51;
            this.dgvDebe.RowTemplate.Height = 24;
            this.dgvDebe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebe.Size = new System.Drawing.Size(731, 294);
            this.dgvDebe.TabIndex = 6;
            // 
            // colDebeFecha
            // 
            this.colDebeFecha.HeaderText = "Fecha";
            this.colDebeFecha.MinimumWidth = 6;
            this.colDebeFecha.Name = "colDebeFecha";
            this.colDebeFecha.ReadOnly = true;
            this.colDebeFecha.Width = 78;
            // 
            // colDebeAsiento
            // 
            this.colDebeAsiento.HeaderText = "N°";
            this.colDebeAsiento.MinimumWidth = 6;
            this.colDebeAsiento.Name = "colDebeAsiento";
            this.colDebeAsiento.ReadOnly = true;
            this.colDebeAsiento.Width = 50;
            // 
            // colDebeReferencia
            // 
            this.colDebeReferencia.HeaderText = "Referencia";
            this.colDebeReferencia.MinimumWidth = 6;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "\'C$\' #,##0.00";
            this.colDebeImporte.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDebeImporte.HeaderText = "Importe";
            this.colDebeImporte.MinimumWidth = 6;
            this.colDebeImporte.Name = "colDebeImporte";
            this.colDebeImporte.ReadOnly = true;
            // 
            // dgvHaber
            // 
            this.dgvHaber.AllowUserToAddRows = false;
            this.dgvHaber.AllowUserToDeleteRows = false;
            this.dgvHaber.AllowUserToResizeRows = false;
            this.dgvHaber.BackgroundColor = System.Drawing.Color.White;
            this.dgvHaber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHaber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHaber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHaber.ColumnHeadersHeight = 30;
            this.dgvHaber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHaberFecha,
            this.colHaberAsiento,
            this.colHaberReferencia,
            this.colHaberConcepto,
            this.colHaberImporte});
            this.dgvHaber.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHaber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHaber.EnableHeadersVisualStyles = false;
            this.dgvHaber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHaber.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHaber.Location = new System.Drawing.Point(786, 154);
            this.dgvHaber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHaber.MultiSelect = false;
            this.dgvHaber.Name = "dgvHaber";
            this.dgvHaber.ReadOnly = true;
            this.dgvHaber.RowHeadersVisible = false;
            this.dgvHaber.RowHeadersWidth = 51;
            this.dgvHaber.RowTemplate.Height = 24;
            this.dgvHaber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHaber.Size = new System.Drawing.Size(731, 294);
            this.dgvHaber.TabIndex = 7;
            // 
            // colHaberFecha
            // 
            this.colHaberFecha.HeaderText = "Fecha";
            this.colHaberFecha.MinimumWidth = 6;
            this.colHaberFecha.Name = "colHaberFecha";
            this.colHaberFecha.ReadOnly = true;
            this.colHaberFecha.Width = 78;
            // 
            // colHaberAsiento
            // 
            this.colHaberAsiento.HeaderText = "N°";
            this.colHaberAsiento.MinimumWidth = 6;
            this.colHaberAsiento.Name = "colHaberAsiento";
            this.colHaberAsiento.ReadOnly = true;
            this.colHaberAsiento.Width = 50;
            // 
            // colHaberReferencia
            // 
            this.colHaberReferencia.HeaderText = "Referencia";
            this.colHaberReferencia.MinimumWidth = 6;
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
            this.colHaberImporte.DefaultCellStyle = dataGridViewCellStyle4;
            this.colHaberImporte.HeaderText = "Importe";
            this.colHaberImporte.MinimumWidth = 6;
            this.colHaberImporte.Name = "colHaberImporte";
            this.colHaberImporte.ReadOnly = true;
            // 
            // lblTotalDebe
            // 
            this.lblTotalDebe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDebe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebe.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDebe.Location = new System.Drawing.Point(23, 454);
            this.lblTotalDebe.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTotalDebe.Name = "lblTotalDebe";
            this.lblTotalDebe.Size = new System.Drawing.Size(731, 28);
            this.lblTotalDebe.TabIndex = 8;
            this.lblTotalDebe.Text = "Total Debe: C$ 0.00";
            this.lblTotalDebe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalHaber
            // 
            this.lblTotalHaber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalHaber.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHaber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalHaber.Location = new System.Drawing.Point(786, 454);
            this.lblTotalHaber.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTotalHaber.Name = "lblTotalHaber";
            this.lblTotalHaber.Size = new System.Drawing.Size(731, 28);
            this.lblTotalHaber.TabIndex = 9;
            this.lblTotalHaber.Text = "Total Haber: C$ 0.00";
            this.lblTotalHaber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultado
            // 
            this.tlpCuentaT.SetColumnSpan(this.lblResultado, 3);
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblResultado.Location = new System.Drawing.Point(23, 488);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(1494, 29);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "SALDO FINAL: C$ 0.00";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblMensaje.Location = new System.Drawing.Point(24, 935);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(24, 4, 4, 12);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(1552, 22);
            this.lblMensaje.TabIndex = 3;
            // 
            // FormConsultarCuentasT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 969);
            this.Controls.Add(this.tlpFondo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Panel panelCuentas;
        private System.Windows.Forms.TableLayoutPanel tlpCuentas;
        private System.Windows.Forms.Label lblCuentasTitulo;
        private System.Windows.Forms.DataGridView dgvCuentasLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaturaleza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Panel panelCuentaT;
        private System.Windows.Forms.TableLayoutPanel tlpCuentaT;
        private System.Windows.Forms.Panel panelBusquedaCuentaT;
        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;
        private System.Windows.Forms.Label lblCuentaTBuscar;
        private System.Windows.Forms.TextBox txtCodigoCuenta;
        private System.Windows.Forms.Button btnBuscarCuentaT;
        private System.Windows.Forms.Panel panelFiltrosFecha;
        private System.Windows.Forms.TableLayoutPanel tlpFiltrosFecha;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnConsultar;
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
