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
            this.panelArbol = new System.Windows.Forms.Panel();
            this.tlpArbol = new System.Windows.Forms.TableLayoutPanel();
            this.lblArbolTitulo = new System.Windows.Forms.Label();
            this.tlpBuscar = new System.Windows.Forms.TableLayoutPanel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.treeCuentas = new System.Windows.Forms.TreeView();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.tlpDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNaturaleza = new System.Windows.Forms.Label();
            this.cboNaturaleza = new System.Windows.Forms.ComboBox();
            this.flpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tlpEliminadas = new System.Windows.Forms.TableLayoutPanel();
            this.lblEliminadasTitulo = new System.Windows.Forms.Label();
            this.lvEliminadas = new System.Windows.Forms.ListView();
            this.colEliminadaCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEliminadaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEliminadaTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReactivar = new System.Windows.Forms.Button();
            this.lblDetalleTitulo = new System.Windows.Forms.Label();
            this.tlpFondo.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.panelArbol.SuspendLayout();
            this.tlpArbol.SuspendLayout();
            this.tlpBuscar.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.tlpDetalle.SuspendLayout();
            this.flpBotones.SuspendLayout();
            this.tlpEliminadas.SuspendLayout();
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
            this.tlpFondo.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(510, 22);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 22, 4, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(427, 39);
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
            this.tlpPrincipal.Location = new System.Drawing.Point(20, 76);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(20, 0, 20, 18);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1407, 752);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // panelArbol
            // 
            this.panelArbol.BackColor = System.Drawing.Color.White;
            this.panelArbol.Controls.Add(this.tlpArbol);
            this.panelArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArbol.Location = new System.Drawing.Point(4, 4);
            this.panelArbol.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panelArbol.Name = "panelArbol";
            this.panelArbol.Size = new System.Drawing.Size(769, 744);
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
            this.tlpArbol.Margin = new System.Windows.Forms.Padding(4);
            this.tlpArbol.Name = "tlpArbol";
            this.tlpArbol.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.tlpArbol.RowCount = 3;
            this.tlpArbol.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArbol.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArbol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpArbol.Size = new System.Drawing.Size(769, 744);
            this.tlpArbol.TabIndex = 0;
            this.tlpArbol.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpArbol_Paint);
            // 
            // lblArbolTitulo
            // 
            this.lblArbolTitulo.AutoSize = true;
            this.lblArbolTitulo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbolTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblArbolTitulo.Location = new System.Drawing.Point(24, 15);
            this.lblArbolTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.lblArbolTitulo.Name = "lblArbolTitulo";
            this.lblArbolTitulo.Size = new System.Drawing.Size(260, 31);
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
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Sienna;
            this.lblBuscar.Location = new System.Drawing.Point(4, 0);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 13, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(64, 36);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBuscar.Location = new System.Drawing.Point(85, 4);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 80;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(640, 30);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // treeCuentas
            // 
            this.treeCuentas.BackColor = System.Drawing.Color.White;
            this.treeCuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeCuentas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.treeCuentas.FullRowSelect = true;
            this.treeCuentas.HideSelection = false;
            this.treeCuentas.Indent = 22;
            this.treeCuentas.ItemHeight = 24;
            this.treeCuentas.LineColor = System.Drawing.Color.Sienna;
            this.treeCuentas.Location = new System.Drawing.Point(24, 108);
            this.treeCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.treeCuentas.Name = "treeCuentas";
            this.treeCuentas.ShowNodeToolTips = true;
            this.treeCuentas.Size = new System.Drawing.Size(721, 617);
            this.treeCuentas.TabIndex = 2;
            this.treeCuentas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCuentas_AfterSelect);
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.White;
            this.panelDetalle.Controls.Add(this.tlpDetalle);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(799, 4);
            this.panelDetalle.Margin = new System.Windows.Forms.Padding(13, 4, 4, 4);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(604, 744);
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
            this.tlpDetalle.Controls.Add(this.lblCodigo, 0, 3);
            this.tlpDetalle.Controls.Add(this.txtCodigo, 1, 3);
            this.tlpDetalle.Controls.Add(this.lblNombre, 0, 4);
            this.tlpDetalle.Controls.Add(this.txtNombre, 1, 4);
            this.tlpDetalle.Controls.Add(this.lblNaturaleza, 0, 5);
            this.tlpDetalle.Controls.Add(this.cboNaturaleza, 1, 5);
            this.tlpDetalle.Controls.Add(this.flpBotones, 0, 6);
            this.tlpDetalle.Controls.Add(this.lblMensaje, 0, 7);
            this.tlpDetalle.Controls.Add(this.tlpEliminadas, 0, 8);
            this.tlpDetalle.Controls.Add(this.lblDetalleTitulo, 0, 0);
            this.tlpDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetalle.Location = new System.Drawing.Point(0, 0);
            this.tlpDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.tlpDetalle.Name = "tlpDetalle";
            this.tlpDetalle.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.tlpDetalle.RowCount = 9;
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetalle.Size = new System.Drawing.Size(604, 744);
            this.tlpDetalle.TabIndex = 0;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoEllipsis = true;
            this.tlpDetalle.SetColumnSpan(this.lblRuta, 2);
            this.lblRuta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRuta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.Sienna;
            this.lblRuta.Location = new System.Drawing.Point(24, 44);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(556, 28);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Seleccione una cuenta en el árbol para consultarla";
            this.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Sienna;
            this.lblTipo.Location = new System.Drawing.Point(24, 76);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(103, 31);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.White;
            this.cboTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboTipo.IntegralHeight = false;
            this.cboTipo.Location = new System.Drawing.Point(144, 76);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(436, 31);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Sienna;
            this.lblCodigo.Location = new System.Drawing.Point(24, 115);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(103, 30);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCodigo.Location = new System.Drawing.Point(144, 115);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(436, 30);
            this.txtCodigo.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Sienna;
            this.lblNombre.Location = new System.Drawing.Point(24, 153);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 30);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtNombre.Location = new System.Drawing.Point(144, 153);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 80;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(436, 30);
            this.txtNombre.TabIndex = 9;
            // 
            // lblNaturaleza
            // 
            this.lblNaturaleza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaturaleza.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaturaleza.ForeColor = System.Drawing.Color.Sienna;
            this.lblNaturaleza.Location = new System.Drawing.Point(24, 191);
            this.lblNaturaleza.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.lblNaturaleza.Name = "lblNaturaleza";
            this.lblNaturaleza.Size = new System.Drawing.Size(103, 31);
            this.lblNaturaleza.TabIndex = 10;
            this.lblNaturaleza.Text = "Naturaleza:";
            this.lblNaturaleza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNaturaleza
            // 
            this.cboNaturaleza.BackColor = System.Drawing.Color.White;
            this.cboNaturaleza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNaturaleza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNaturaleza.Enabled = false;
            this.cboNaturaleza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNaturaleza.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNaturaleza.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboNaturaleza.IntegralHeight = false;
            this.cboNaturaleza.Location = new System.Drawing.Point(144, 191);
            this.cboNaturaleza.Margin = new System.Windows.Forms.Padding(4);
            this.cboNaturaleza.Name = "cboNaturaleza";
            this.cboNaturaleza.Size = new System.Drawing.Size(436, 31);
            this.cboNaturaleza.TabIndex = 11;
            this.cboNaturaleza.TabStop = false;
            // 
            // flpBotones
            // 
            this.flpBotones.ColumnCount = 2;
            this.tlpDetalle.SetColumnSpan(this.flpBotones, 2);
            this.flpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flpBotones.Controls.Add(this.btnAgregar, 0, 0);
            this.flpBotones.Controls.Add(this.btnModificar, 1, 0);
            this.flpBotones.Controls.Add(this.btnEliminar, 0, 1);
            this.flpBotones.Controls.Add(this.btnLimpiar, 1, 1);
            this.flpBotones.Controls.Add(this.btnGuardarCambios, 0, 2);
            this.flpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotones.Location = new System.Drawing.Point(20, 236);
            this.flpBotones.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.RowCount = 3;
            this.flpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.flpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.flpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.flpBotones.Size = new System.Drawing.Size(564, 138);
            this.flpBotones.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Tan;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::WindowsFormsApp1.Properties.Resources.other_admission_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnAgregar.Location = new System.Drawing.Point(4, 4);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(274, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::WindowsFormsApp1.Properties.Resources.contract_edit_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnModificar.Location = new System.Drawing.Point(286, 4);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(274, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Sienna;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::WindowsFormsApp1.Properties.Resources.free_cancellation_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnEliminar.Location = new System.Drawing.Point(4, 50);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(274, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Sienna;
            this.btnLimpiar.Location = new System.Drawing.Point(286, 50);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(274, 38);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.SeaGreen;
            this.flpBotones.SetColumnSpan(this.btnGuardarCambios, 2);
            this.btnGuardarCambios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Image = global::WindowsFormsApp1.Properties.Resources.save_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnGuardarCambios.Location = new System.Drawing.Point(4, 96);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(556, 38);
            this.btnGuardarCambios.TabIndex = 4;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoEllipsis = true;
            this.tlpDetalle.SetColumnSpan(this.lblMensaje, 2);
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Sienna;
            this.lblMensaje.Location = new System.Drawing.Point(24, 384);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(556, 26);
            this.lblMensaje.TabIndex = 17;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpEliminadas
            // 
            this.tlpEliminadas.ColumnCount = 1;
            this.tlpDetalle.SetColumnSpan(this.tlpEliminadas, 2);
            this.tlpEliminadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEliminadas.Controls.Add(this.lblEliminadasTitulo, 0, 0);
            this.tlpEliminadas.Controls.Add(this.lvEliminadas, 0, 1);
            this.tlpEliminadas.Controls.Add(this.btnReactivar, 0, 2);
            this.tlpEliminadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEliminadas.Location = new System.Drawing.Point(24, 414);
            this.tlpEliminadas.Margin = new System.Windows.Forms.Padding(4);
            this.tlpEliminadas.Name = "tlpEliminadas";
            this.tlpEliminadas.RowCount = 3;
            this.tlpEliminadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEliminadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEliminadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpEliminadas.Size = new System.Drawing.Size(556, 316);
            this.tlpEliminadas.TabIndex = 18;
            // 
            // lblEliminadasTitulo
            // 
            this.lblEliminadasTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEliminadasTitulo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminadasTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEliminadasTitulo.Location = new System.Drawing.Point(4, 0);
            this.lblEliminadasTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblEliminadasTitulo.Name = "lblEliminadasTitulo";
            this.lblEliminadasTitulo.Size = new System.Drawing.Size(548, 24);
            this.lblEliminadasTitulo.TabIndex = 0;
            this.lblEliminadasTitulo.Text = "Cuentas eliminadas";
            this.lblEliminadasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvEliminadas
            // 
            this.lvEliminadas.BackColor = System.Drawing.Color.White;
            this.lvEliminadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEliminadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEliminadaCodigo,
            this.colEliminadaNombre,
            this.colEliminadaTipo});
            this.lvEliminadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEliminadas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEliminadas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lvEliminadas.FullRowSelect = true;
            this.lvEliminadas.HideSelection = false;
            this.lvEliminadas.Location = new System.Drawing.Point(4, 32);
            this.lvEliminadas.Margin = new System.Windows.Forms.Padding(4);
            this.lvEliminadas.MultiSelect = false;
            this.lvEliminadas.Name = "lvEliminadas";
            this.lvEliminadas.Size = new System.Drawing.Size(548, 234);
            this.lvEliminadas.TabIndex = 1;
            this.lvEliminadas.UseCompatibleStateImageBehavior = false;
            this.lvEliminadas.View = System.Windows.Forms.View.Details;
            this.lvEliminadas.SelectedIndexChanged += new System.EventHandler(this.lvEliminadas_SelectedIndexChanged);
            this.lvEliminadas.DoubleClick += new System.EventHandler(this.lvEliminadas_DoubleClick);
            // 
            // colEliminadaCodigo
            // 
            this.colEliminadaCodigo.Text = "Código";
            this.colEliminadaCodigo.Width = 100;
            // 
            // colEliminadaNombre
            // 
            this.colEliminadaNombre.Text = "Nombre";
            this.colEliminadaNombre.Width = 280;
            // 
            // colEliminadaTipo
            // 
            this.colEliminadaTipo.Text = "Tipo";
            this.colEliminadaTipo.Width = 140;
            // 
            // btnReactivar
            // 
            this.btnReactivar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReactivar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReactivar.FlatAppearance.BorderSize = 0;
            this.btnReactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactivar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivar.ForeColor = System.Drawing.Color.White;
            this.btnReactivar.Image = global::WindowsFormsApp1.Properties.Resources.other_admission_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnReactivar.Location = new System.Drawing.Point(4, 274);
            this.btnReactivar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(548, 38);
            this.btnReactivar.TabIndex = 2;
            this.btnReactivar.Text = "Reactivar cuenta";
            this.btnReactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReactivar.UseVisualStyleBackColor = false;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // lblDetalleTitulo
            // 
            this.tlpDetalle.SetColumnSpan(this.lblDetalleTitulo, 2);
            this.lblDetalleTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetalleTitulo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDetalleTitulo.Location = new System.Drawing.Point(24, 10);
            this.lblDetalleTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalleTitulo.Name = "lblDetalleTitulo";
            this.lblDetalleTitulo.Size = new System.Drawing.Size(556, 34);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.flpBotones.ResumeLayout(false);
            this.tlpEliminadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel panelArbol;
        private System.Windows.Forms.TableLayoutPanel tlpArbol;
        private System.Windows.Forms.Label lblArbolTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TreeView treeCuentas;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.TableLayoutPanel tlpDetalle;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNaturaleza;
        private System.Windows.Forms.ComboBox cboNaturaleza;
        private System.Windows.Forms.TableLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TableLayoutPanel tlpEliminadas;
        private System.Windows.Forms.Label lblEliminadasTitulo;
        private System.Windows.Forms.ListView lvEliminadas;
        private System.Windows.Forms.ColumnHeader colEliminadaCodigo;
        private System.Windows.Forms.ColumnHeader colEliminadaNombre;
        private System.Windows.Forms.ColumnHeader colEliminadaTipo;
        private System.Windows.Forms.Button btnReactivar;
    }
}
