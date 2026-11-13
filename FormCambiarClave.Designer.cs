namespace WindowsFormsApp1
{
    partial class FormCambiarClave
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
            this.card = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblActual = new System.Windows.Forms.Label();
            this.tlpActual = new System.Windows.Forms.TableLayoutPanel();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.btnOjoActual = new System.Windows.Forms.Button();
            this.lblNueva = new System.Windows.Forms.Label();
            this.tlpNueva = new System.Windows.Forms.TableLayoutPanel();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.btnOjoNueva = new System.Windows.Forms.Button();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.tlpConfirmar = new System.Windows.Forms.TableLayoutPanel();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnOjoConfirmar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpFondo.SuspendLayout();
            this.card.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.tlpActual.SuspendLayout();
            this.tlpNueva.SuspendLayout();
            this.tlpConfirmar.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFondo
            // 
            this.tlpFondo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tlpFondo.ColumnCount = 3;
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.Controls.Add(this.card, 1, 1);
            this.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFondo.Location = new System.Drawing.Point(0, 0);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.RowCount = 3;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.Size = new System.Drawing.Size(520, 640);
            this.tlpFondo.TabIndex = 0;
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.Controls.Add(this.tlpContenido);
            this.card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card.FillColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(30, 30);
            this.card.Margin = new System.Windows.Forms.Padding(0);
            this.card.Name = "card";
            this.card.Padding = new System.Windows.Forms.Padding(30, 24, 30, 24);
            this.card.Radius = 25;
            this.card.ShadowColor = System.Drawing.Color.Black;
            this.card.Size = new System.Drawing.Size(460, 580);
            this.card.TabIndex = 0;
            // 
            // tlpContenido
            // 
            this.tlpContenido.BackColor = System.Drawing.Color.Transparent;
            this.tlpContenido.ColumnCount = 1;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpContenido.Controls.Add(this.lblSubtitulo, 0, 1);
            this.tlpContenido.Controls.Add(this.lblUsuario, 0, 2);
            this.tlpContenido.Controls.Add(this.txtUsuario, 0, 3);
            this.tlpContenido.Controls.Add(this.lblActual, 0, 4);
            this.tlpContenido.Controls.Add(this.tlpActual, 0, 5);
            this.tlpContenido.Controls.Add(this.lblNueva, 0, 6);
            this.tlpContenido.Controls.Add(this.tlpNueva, 0, 7);
            this.tlpContenido.Controls.Add(this.lblConfirmar, 0, 8);
            this.tlpContenido.Controls.Add(this.tlpConfirmar, 0, 9);
            this.tlpContenido.Controls.Add(this.lblError, 0, 10);
            this.tlpContenido.Controls.Add(this.tlpBotones, 0, 11);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(30, 24);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 13;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(400, 532);
            this.tlpContenido.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cambiar contraseña";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Sienna;
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 40);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(400, 28);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Ingrese la contraseña actual y defina la nueva.";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblUsuario.Location = new System.Drawing.Point(0, 74);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(400, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nombre de usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtUsuario.Location = new System.Drawing.Point(0, 98);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(400, 26);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblActual
            // 
            this.lblActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblActual.Location = new System.Drawing.Point(0, 130);
            this.lblActual.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(400, 18);
            this.lblActual.TabIndex = 4;
            this.lblActual.Text = "Contraseña actual";
            this.lblActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpActual
            // 
            this.tlpActual.BackColor = System.Drawing.Color.Transparent;
            this.tlpActual.ColumnCount = 2;
            this.tlpActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpActual.Controls.Add(this.txtActual, 0, 0);
            this.tlpActual.Controls.Add(this.btnOjoActual, 1, 0);
            this.tlpActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActual.Location = new System.Drawing.Point(0, 154);
            this.tlpActual.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.tlpActual.Name = "tlpActual";
            this.tlpActual.RowCount = 1;
            this.tlpActual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActual.Size = new System.Drawing.Size(400, 26);
            this.tlpActual.TabIndex = 1;
            // 
            // txtActual
            // 
            this.txtActual.BackColor = System.Drawing.Color.White;
            this.txtActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtActual.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActual.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtActual.Location = new System.Drawing.Point(0, 0);
            this.txtActual.Margin = new System.Windows.Forms.Padding(0);
            this.txtActual.MaxLength = 100;
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '\u25CF';
            this.txtActual.Size = new System.Drawing.Size(366, 26);
            this.txtActual.TabIndex = 0;
            this.txtActual.TextChanged += new System.EventHandler(this.txtActual_TextChanged);
            // 
            // btnOjoActual
            // 
            this.btnOjoActual.AccessibleName = "Mostrar contraseña";
            this.btnOjoActual.BackColor = System.Drawing.Color.White;
            this.btnOjoActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOjoActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOjoActual.FlatAppearance.BorderSize = 0;
            this.btnOjoActual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnOjoActual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnOjoActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOjoActual.Location = new System.Drawing.Point(366, 0);
            this.btnOjoActual.Margin = new System.Windows.Forms.Padding(0);
            this.btnOjoActual.Name = "btnOjoActual";
            this.btnOjoActual.Size = new System.Drawing.Size(34, 26);
            this.btnOjoActual.TabIndex = 1;
            this.btnOjoActual.TabStop = false;
            this.btnOjoActual.UseVisualStyleBackColor = false;
            this.btnOjoActual.Click += new System.EventHandler(this.btnOjoActual_Click);
            this.btnOjoActual.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOjoActual_Paint);
            // 
            // lblNueva
            // 
            this.lblNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNueva.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNueva.Location = new System.Drawing.Point(0, 186);
            this.lblNueva.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(400, 18);
            this.lblNueva.TabIndex = 6;
            this.lblNueva.Text = "Nueva contraseña";
            this.lblNueva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpNueva
            // 
            this.tlpNueva.BackColor = System.Drawing.Color.Transparent;
            this.tlpNueva.ColumnCount = 2;
            this.tlpNueva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNueva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpNueva.Controls.Add(this.txtNueva, 0, 0);
            this.tlpNueva.Controls.Add(this.btnOjoNueva, 1, 0);
            this.tlpNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNueva.Location = new System.Drawing.Point(0, 210);
            this.tlpNueva.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.tlpNueva.Name = "tlpNueva";
            this.tlpNueva.RowCount = 1;
            this.tlpNueva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNueva.Size = new System.Drawing.Size(400, 26);
            this.tlpNueva.TabIndex = 2;
            // 
            // txtNueva
            // 
            this.txtNueva.BackColor = System.Drawing.Color.White;
            this.txtNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNueva.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueva.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtNueva.Location = new System.Drawing.Point(0, 0);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(0);
            this.txtNueva.MaxLength = 100;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '\u25CF';
            this.txtNueva.Size = new System.Drawing.Size(366, 26);
            this.txtNueva.TabIndex = 0;
            this.txtNueva.TextChanged += new System.EventHandler(this.txtNueva_TextChanged);
            // 
            // btnOjoNueva
            // 
            this.btnOjoNueva.AccessibleName = "Mostrar contraseña";
            this.btnOjoNueva.BackColor = System.Drawing.Color.White;
            this.btnOjoNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOjoNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOjoNueva.FlatAppearance.BorderSize = 0;
            this.btnOjoNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnOjoNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnOjoNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOjoNueva.Location = new System.Drawing.Point(366, 0);
            this.btnOjoNueva.Margin = new System.Windows.Forms.Padding(0);
            this.btnOjoNueva.Name = "btnOjoNueva";
            this.btnOjoNueva.Size = new System.Drawing.Size(34, 26);
            this.btnOjoNueva.TabIndex = 1;
            this.btnOjoNueva.TabStop = false;
            this.btnOjoNueva.UseVisualStyleBackColor = false;
            this.btnOjoNueva.Click += new System.EventHandler(this.btnOjoNueva_Click);
            this.btnOjoNueva.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOjoNueva_Paint);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblConfirmar.Location = new System.Drawing.Point(0, 242);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(400, 18);
            this.lblConfirmar.TabIndex = 8;
            this.lblConfirmar.Text = "Confirmar nueva contraseña";
            this.lblConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpConfirmar
            // 
            this.tlpConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.tlpConfirmar.ColumnCount = 2;
            this.tlpConfirmar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConfirmar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpConfirmar.Controls.Add(this.txtConfirmar, 0, 0);
            this.tlpConfirmar.Controls.Add(this.btnOjoConfirmar, 1, 0);
            this.tlpConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConfirmar.Location = new System.Drawing.Point(0, 266);
            this.tlpConfirmar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.tlpConfirmar.Name = "tlpConfirmar";
            this.tlpConfirmar.RowCount = 1;
            this.tlpConfirmar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConfirmar.Size = new System.Drawing.Size(400, 26);
            this.tlpConfirmar.TabIndex = 3;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.Color.White;
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtConfirmar.Location = new System.Drawing.Point(0, 0);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmar.MaxLength = 100;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '\u25CF';
            this.txtConfirmar.Size = new System.Drawing.Size(366, 26);
            this.txtConfirmar.TabIndex = 0;
            this.txtConfirmar.TextChanged += new System.EventHandler(this.txtConfirmar_TextChanged);
            // 
            // btnOjoConfirmar
            // 
            this.btnOjoConfirmar.AccessibleName = "Mostrar contraseña";
            this.btnOjoConfirmar.BackColor = System.Drawing.Color.White;
            this.btnOjoConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOjoConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOjoConfirmar.FlatAppearance.BorderSize = 0;
            this.btnOjoConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnOjoConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnOjoConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOjoConfirmar.Location = new System.Drawing.Point(366, 0);
            this.btnOjoConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btnOjoConfirmar.Name = "btnOjoConfirmar";
            this.btnOjoConfirmar.Size = new System.Drawing.Size(34, 26);
            this.btnOjoConfirmar.TabIndex = 1;
            this.btnOjoConfirmar.TabStop = false;
            this.btnOjoConfirmar.UseVisualStyleBackColor = false;
            this.btnOjoConfirmar.Click += new System.EventHandler(this.btnOjoConfirmar_Click);
            this.btnOjoConfirmar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOjoConfirmar_Paint);
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(0, 298);
            this.lblError.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(400, 26);
            this.lblError.TabIndex = 10;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.Transparent;
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnCambiar, 0, 0);
            this.tlpBotones.Controls.Add(this.btnCancelar, 1, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(0, 328);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(400, 46);
            this.tlpBotones.TabIndex = 11;
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.Tan;
            this.btnCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.White;
            this.btnCambiar.Location = new System.Drawing.Point(0, 0);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(196, 46);
            this.btnCambiar.TabIndex = 0;
            this.btnCambiar.Text = "Cambiar contraseña";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Sienna;
            this.btnCancelar.Location = new System.Drawing.Point(204, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(196, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormCambiarClave
            // 
            this.AcceptButton = this.btnCambiar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(520, 640);
            this.Controls.Add(this.tlpFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            this.tlpFondo.ResumeLayout(false);
            this.card.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.tlpContenido.PerformLayout();
            this.tlpActual.ResumeLayout(false);
            this.tlpActual.PerformLayout();
            this.tlpNueva.ResumeLayout(false);
            this.tlpNueva.PerformLayout();
            this.tlpConfirmar.ResumeLayout(false);
            this.tlpConfirmar.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private Guna.UI2.WinForms.Guna2ShadowPanel card;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TableLayoutPanel tlpActual;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.Button btnOjoActual;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TableLayoutPanel tlpNueva;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Button btnOjoNueva;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TableLayoutPanel tlpConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnOjoConfirmar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
