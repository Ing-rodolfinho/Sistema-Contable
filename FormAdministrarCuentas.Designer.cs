namespace WindowsFormsApp1
{
    partial class FormAdministrarCuentas
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
            this.tlpFondo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelArbol = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpArbol = new System.Windows.Forms.TableLayoutPanel();
            this.lblArbolTitulo = new System.Windows.Forms.Label();
            this.tlpBuscar = new System.Windows.Forms.TableLayoutPanel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.treeCuentas = new System.Windows.Forms.TreeView();
            this.panelDetalle = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cboGrupo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNaturaleza = new System.Windows.Forms.Label();
            this.cboNaturaleza = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.numSaldo = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardarCambios = new Guna.UI2.WinForms.Guna2Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblDetalleTitulo = new System.Windows.Forms.Label();
            this.tlpFondo.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.panelArbol.SuspendLayout();
            this.tlpArbol.SuspendLayout();
            this.tlpBuscar.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.tlpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).BeginInit();
            this.flpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFondo
            // 
            this.tlpFondo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tlpFondo.ColumnCount = 1;
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpFondo.Controls.Add(this.tlpPrincipal, 0, 1);
            this.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFondo.Location = new System.Drawing.Point(0, 0);
            this.tlpFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.RowCount = 2;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.Size = new System.Drawing.Size(1447, 846);
            this.tlpFondo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(500, 22);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 22, 4, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(446, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRAR CUENTAS";
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.86354F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.13646F));
            this.tlpPrincipal.Controls.Add(this.panelArbol, 0, 0);
            this.tlpPrincipal.Controls.Add(this.panelDetalle, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(20, 79);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(20, 0, 20, 18);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1407, 749);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // panelArbol
            // 
            this.panelArbol.BackColor = System.Drawing.Color.Transparent;
            this.panelArbol.Controls.Add(this.tlpArbol);
            this.panelArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArbol.FillColor = System.Drawing.Color.White;
            this.panelArbol.Location = new System.Drawing.Point(4, 4);
            this.panelArbol.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panelArbol.Name = "panelArbol";
            this.panelArbol.Radius = 20;
            this.panelArbol.ShadowColor = System.Drawing.Color.Black;
            this.panelArbol.Size = new System.Drawing.Size(769, 741);
            this.panelArbol.TabIndex = 0;
            // 
            // tlpArbol
            // 
            this.tlpArbol.ColumnCount = 1;
            this.tlpArbol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpArbol.Controls.Add(this.lblArbolTitulo, 0, 0);
            this.tlpArbol.Controls.Add(this.tlpBuscar, 0, 1);
            this.tlpArbol.Controls.Add(this.treeCuentas, 0, 2);
            this.tlpArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArbol.Location = new System.Drawing.Point(0, 0);
            this.tlpArbol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpArbol.Name = "tlpArbol";
            this.tlpArbol.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.tlpArbol.RowCount = 3;
            this.tlpArbol.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArbol.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArbol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpArbol.Size = new System.Drawing.Size(769, 741);
            this.tlpArbol.TabIndex = 0;
            this.tlpArbol.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpArbol_Paint);
            // 
            // lblArbolTitulo
            // 
            this.lblArbolTitulo.AutoSize = true;
            this.lblArbolTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbolTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblArbolTitulo.Location = new System.Drawing.Point(24, 15);
            this.lblArbolTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.lblArbolTitulo.Name = "lblArbolTitulo";
            this.lblArbolTitulo.Size = new System.Drawing.Size(240, 31);
            this.lblArbolTitulo.TabIndex = 0;
            this.lblArbolTitulo.Text = "Catálogo de Cuentas";
            // 
            // tlpBuscar
            // 
            this.tlpBuscar.ColumnCount = 2;
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBuscar.Controls.Add(this.lblBuscar, 0, 0);
            this.tlpBuscar.Controls.Add(this.txtBuscar, 1, 0);
            this.tlpBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBuscar.Location = new System.Drawing.Point(20, 58);
            this.tlpBuscar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tlpBuscar.Name = "tlpBuscar";
            this.tlpBuscar.RowCount = 1;
            this.tlpBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBuscar.Size = new System.Drawing.Size(729, 36);
            this.tlpBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuscar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Sienna;
            this.lblBuscar.Location = new System.Drawing.Point(4, 0);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 13, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 36);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBuscar.Location = new System.Drawing.Point(83, 4);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(642, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // treeCuentas
            // 
            this.treeCuentas.BackColor = System.Drawing.Color.White;
            this.treeCuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCuentas.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeCuentas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.treeCuentas.FullRowSelect = true;
            this.treeCuentas.HideSelection = false;
            this.treeCuentas.Indent = 22;
            this.treeCuentas.ItemHeight = 24;
            this.treeCuentas.LineColor = System.Drawing.Color.Sienna;
            this.treeCuentas.Location = new System.Drawing.Point(24, 108);
            this.treeCuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeCuentas.Name = "treeCuentas";
            this.treeCuentas.ShowNodeToolTips = true;
            this.treeCuentas.Size = new System.Drawing.Size(721, 614);
            this.treeCuentas.TabIndex = 2;
            this.treeCuentas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCuentas_AfterSelect);
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.Transparent;
            this.panelDetalle.Controls.Add(this.tlpDetalle);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.FillColor = System.Drawing.Color.White;
            this.panelDetalle.Location = new System.Drawing.Point(799, 4);
            this.panelDetalle.Margin = new System.Windows.Forms.Padding(13, 4, 4, 4);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Radius = 20;
            this.panelDetalle.ShadowColor = System.Drawing.Color.Black;
            this.panelDetalle.Size = new System.Drawing.Size(604, 741);
            this.panelDetalle.TabIndex = 1;
            // 
            // tlpDetalle
            // 
            this.tlpDetalle.ColumnCount = 2;
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetalle.Controls.Add(this.lblRuta, 0, 1);
            this.tlpDetalle.Controls.Add(this.lblTipo, 0, 2);
            this.tlpDetalle.Controls.Add(this.cboTipo, 1, 2);
            this.tlpDetalle.Controls.Add(this.lblGrupo, 0, 3);
            this.tlpDetalle.Controls.Add(this.cboGrupo, 1, 3);
            this.tlpDetalle.Controls.Add(this.lblCodigo, 0, 4);
            this.tlpDetalle.Controls.Add(this.txtCodigo, 1, 4);
            this.tlpDetalle.Controls.Add(this.lblNombre, 0, 5);
            this.tlpDetalle.Controls.Add(this.txtNombre, 1, 5);
            this.tlpDetalle.Controls.Add(this.lblNaturaleza, 0, 6);
            this.tlpDetalle.Controls.Add(this.cboNaturaleza, 1, 6);
            this.tlpDetalle.Controls.Add(this.lblSaldo, 0, 7);
            this.tlpDetalle.Controls.Add(this.numSaldo, 1, 7);
            this.tlpDetalle.Controls.Add(this.lblEstado, 0, 8);
            this.tlpDetalle.Controls.Add(this.cboEstado, 1, 8);
            this.tlpDetalle.Controls.Add(this.flpBotones, 0, 9);
            this.tlpDetalle.Controls.Add(this.lblMensaje, 0, 10);
            this.tlpDetalle.Controls.Add(this.lblDetalleTitulo, 1, 0);
            this.tlpDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetalle.Location = new System.Drawing.Point(0, 0);
            this.tlpDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpDetalle.Name = "tlpDetalle";
            this.tlpDetalle.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.tlpDetalle.RowCount = 12;
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetalle.Size = new System.Drawing.Size(604, 741);
            this.tlpDetalle.TabIndex = 0;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.tlpDetalle.SetColumnSpan(this.lblRuta, 2);
            this.lblRuta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRuta.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.Sienna;
            this.lblRuta.Location = new System.Drawing.Point(24, 61);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 17);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(556, 17);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Seleccione una cuenta en el árbol para consultarla";
            this.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Sienna;
            this.lblTipo.Location = new System.Drawing.Point(24, 99);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(103, 36);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.Transparent;
            this.cboTipo.BorderColor = System.Drawing.Color.Tan;
            this.cboTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FocusedColor = System.Drawing.Color.Sienna;
            this.cboTipo.FocusedState.BorderColor = System.Drawing.Color.Sienna;
            this.cboTipo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboTipo.ItemHeight = 30;
            this.cboTipo.Location = new System.Drawing.Point(144, 99);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(436, 36);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrupo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.Sienna;
            this.lblGrupo.Location = new System.Drawing.Point(24, 143);
            this.lblGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(103, 36);
            this.lblGrupo.TabIndex = 4;
            this.lblGrupo.Text = "Grupo:";
            this.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboGrupo
            // 
            this.cboGrupo.BackColor = System.Drawing.Color.Transparent;
            this.cboGrupo.BorderColor = System.Drawing.Color.Tan;
            this.cboGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FocusedColor = System.Drawing.Color.Sienna;
            this.cboGrupo.FocusedState.BorderColor = System.Drawing.Color.Sienna;
            this.cboGrupo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboGrupo.ItemHeight = 30;
            this.cboGrupo.Location = new System.Drawing.Point(144, 143);
            this.cboGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(436, 36);
            this.cboGrupo.TabIndex = 5;
            this.cboGrupo.SelectedIndexChanged += new System.EventHandler(this.cboGrupo_SelectedIndexChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Sienna;
            this.lblCodigo.Location = new System.Drawing.Point(24, 187);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(103, 26);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCodigo.Location = new System.Drawing.Point(144, 187);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(436, 26);
            this.txtCodigo.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Sienna;
            this.lblNombre.Location = new System.Drawing.Point(24, 221);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 26);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtNombre.Location = new System.Drawing.Point(144, 221);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MaxLength = 80;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(436, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // lblNaturaleza
            // 
            this.lblNaturaleza.AutoSize = true;
            this.lblNaturaleza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaturaleza.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaturaleza.ForeColor = System.Drawing.Color.Sienna;
            this.lblNaturaleza.Location = new System.Drawing.Point(24, 255);
            this.lblNaturaleza.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblNaturaleza.Name = "lblNaturaleza";
            this.lblNaturaleza.Size = new System.Drawing.Size(103, 36);
            this.lblNaturaleza.TabIndex = 10;
            this.lblNaturaleza.Text = "Naturaleza:";
            this.lblNaturaleza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNaturaleza
            // 
            this.cboNaturaleza.BackColor = System.Drawing.Color.Transparent;
            this.cboNaturaleza.BorderColor = System.Drawing.Color.Tan;
            this.cboNaturaleza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNaturaleza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNaturaleza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNaturaleza.FocusedColor = System.Drawing.Color.Sienna;
            this.cboNaturaleza.FocusedState.BorderColor = System.Drawing.Color.Sienna;
            this.cboNaturaleza.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNaturaleza.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboNaturaleza.ItemHeight = 30;
            this.cboNaturaleza.Location = new System.Drawing.Point(144, 255);
            this.cboNaturaleza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNaturaleza.Name = "cboNaturaleza";
            this.cboNaturaleza.Size = new System.Drawing.Size(436, 36);
            this.cboNaturaleza.TabIndex = 11;
            this.cboNaturaleza.SelectedIndexChanged += new System.EventHandler(this.cboNaturaleza_SelectedIndexChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaldo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Sienna;
            this.lblSaldo.Location = new System.Drawing.Point(24, 299);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(103, 32);
            this.lblSaldo.TabIndex = 12;
            this.lblSaldo.Text = "Saldo:";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSaldo
            // 
            this.numSaldo.BackColor = System.Drawing.Color.Transparent;
            this.numSaldo.BorderColor = System.Drawing.Color.Tan;
            this.numSaldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSaldo.DecimalPlaces = 2;
            this.numSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSaldo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSaldo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numSaldo.Location = new System.Drawing.Point(144, 300);
            this.numSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSaldo.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            131072});
            this.numSaldo.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147352576});
            this.numSaldo.Name = "numSaldo";
            this.numSaldo.Size = new System.Drawing.Size(436, 30);
            this.numSaldo.TabIndex = 13;
            this.numSaldo.ThousandsSeparator = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Sienna;
            this.lblEstado.Location = new System.Drawing.Point(24, 339);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 36);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.Color.Transparent;
            this.cboEstado.BorderColor = System.Drawing.Color.Tan;
            this.cboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FocusedColor = System.Drawing.Color.Sienna;
            this.cboEstado.FocusedState.BorderColor = System.Drawing.Color.Sienna;
            this.cboEstado.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboEstado.ItemHeight = 30;
            this.cboEstado.Location = new System.Drawing.Point(144, 339);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(436, 36);
            this.cboEstado.TabIndex = 15;
            // 
            // flpBotones
            // 
            this.flpBotones.AutoSize = true;
            this.tlpDetalle.SetColumnSpan(this.flpBotones, 2);
            this.flpBotones.Controls.Add(this.btnAgregar);
            this.flpBotones.Controls.Add(this.btnModificar);
            this.flpBotones.Controls.Add(this.btnEliminar);
            this.flpBotones.Controls.Add(this.btnLimpiar);
            this.flpBotones.Controls.Add(this.btnGuardarCambios);
            this.flpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotones.Location = new System.Drawing.Point(20, 389);
            this.flpBotones.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(564, 114);
            this.flpBotones.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 15;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.Tan;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::WindowsFormsApp1.Properties.Resources.other_admission_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnAgregar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAgregar.Location = new System.Drawing.Point(4, 4);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 49);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 15;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::WindowsFormsApp1.Properties.Resources.contract_edit_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnModificar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnModificar.Location = new System.Drawing.Point(145, 4);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 49);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 15;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.Sienna;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::WindowsFormsApp1.Properties.Resources.free_cancellation_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnEliminar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnEliminar.Location = new System.Drawing.Point(300, 4);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 49);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderRadius = 15;
            this.btnLimpiar.CustomBorderColor = System.Drawing.Color.Sienna;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Sienna;
            this.btnLimpiar.Location = new System.Drawing.Point(4, 61);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 49);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BorderRadius = 15;
            this.btnGuardarCambios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCambios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarCambios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarCambios.FillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Image = global::WindowsFormsApp1.Properties.Resources.save_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnGuardarCambios.ImageSize = new System.Drawing.Size(22, 22);
            this.btnGuardarCambios.Location = new System.Drawing.Point(137, 61);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(180, 49);
            this.btnGuardarCambios.TabIndex = 4;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.tlpDetalle.SetColumnSpan(this.lblMensaje, 2);
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Sienna;
            this.lblMensaje.Location = new System.Drawing.Point(24, 513);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(556, 20);
            this.lblMensaje.TabIndex = 17;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetalleTitulo
            // 
            this.lblDetalleTitulo.AutoSize = true;
            this.lblDetalleTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDetalleTitulo.Location = new System.Drawing.Point(144, 15);
            this.lblDetalleTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.lblDetalleTitulo.Name = "lblDetalleTitulo";
            this.lblDetalleTitulo.Size = new System.Drawing.Size(238, 31);
            this.lblDetalleTitulo.TabIndex = 0;
            this.lblDetalleTitulo.Text = "Detalle de la Cuenta";
            this.lblDetalleTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDetalleTitulo.Click += new System.EventHandler(this.lblDetalleTitulo_Click);
            // 
            // FormAdministrarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 846);
            this.Controls.Add(this.tlpFondo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdministrarCuentas";
            this.Text = "Administrar Cuentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdministrarCuentas_FormClosing);
            this.Load += new System.EventHandler(this.FormAdministrarCuentas_Load);
            this.tlpFondo.ResumeLayout(false);
            this.tlpFondo.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.panelArbol.ResumeLayout(false);
            this.tlpArbol.ResumeLayout(false);
            this.tlpArbol.PerformLayout();
            this.tlpBuscar.ResumeLayout(false);
            this.tlpBuscar.PerformLayout();
            this.panelDetalle.ResumeLayout(false);
            this.tlpDetalle.ResumeLayout(false);
            this.tlpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).EndInit();
            this.flpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelArbol;
        private System.Windows.Forms.TableLayoutPanel tlpArbol;
        private System.Windows.Forms.Label lblArbolTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TreeView treeCuentas;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelDetalle;
        private System.Windows.Forms.TableLayoutPanel tlpDetalle;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblTipo;
        private Guna.UI2.WinForms.Guna2ComboBox cboTipo;
        private System.Windows.Forms.Label lblGrupo;
        private Guna.UI2.WinForms.Guna2ComboBox cboGrupo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNaturaleza;
        private Guna.UI2.WinForms.Guna2ComboBox cboNaturaleza;
        private System.Windows.Forms.Label lblSaldo;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSaldo;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2ComboBox cboEstado;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnGuardarCambios;
        private System.Windows.Forms.Label lblMensaje;
    }
}
