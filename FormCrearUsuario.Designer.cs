namespace WindowsFormsApp1
{
    partial class FormCrearUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.tlpClave = new System.Windows.Forms.TableLayoutPanel();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnOjo = new System.Windows.Forms.Button();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.tlpConfirmar = new System.Windows.Forms.TableLayoutPanel();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnOjoConfirmar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpFondo.SuspendLayout();
            this.card.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.tlpClave.SuspendLayout();
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
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.Size = new System.Drawing.Size(520, 600);
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
            this.card.Size = new System.Drawing.Size(460, 540);
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
            this.tlpContenido.Controls.Add(this.lblNombre, 0, 4);
            this.tlpContenido.Controls.Add(this.txtNombre, 0, 5);
            this.tlpContenido.Controls.Add(this.lblClave, 0, 6);
            this.tlpContenido.Controls.Add(this.tlpClave, 0, 7);
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
            this.tlpContenido.Size = new System.Drawing.Size(400, 492);
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
            this.lblTitulo.Text = "Crear cuenta de usuario";
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
            this.lblSubtitulo.Text = "Registre un nuevo usuario del sistema.";
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
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(400, 26);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNombre.Location = new System.Drawing.Point(0, 130);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(400, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre completo";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtNombre.Location = new System.Drawing.Point(0, 154);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblClave
            // 
            this.lblClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblClave.Location = new System.Drawing.Point(0, 186);
            this.lblClave.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(400, 18);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Contraseña";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpClave
            // 
            this.tlpClave.BackColor = System.Drawing.Color.Transparent;
            this.tlpClave.ColumnCount = 2;
            this.tlpClave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpClave.Controls.Add(this.txtClave, 0, 0);
            this.tlpClave.Controls.Add(this.btnOjo, 1, 0);
            this.tlpClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClave.Location = new System.Drawing.Point(0, 210);
            this.tlpClave.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.tlpClave.Name = "tlpClave";
            this.tlpClave.RowCount = 1;
            this.tlpClave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClave.Size = new System.Drawing.Size(400, 26);
            this.tlpClave.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtClave.Location = new System.Drawing.Point(0, 0);
            this.txtClave.Margin = new System.Windows.Forms.Padding(0);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\u25CF';
            this.txtClave.Size = new System.Drawing.Size(366, 26);
            this.txtClave.TabIndex = 0;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // btnOjo
            // 
            this.btnOjo.AccessibleName = "Mostrar contraseña";
            this.btnOjo.BackColor = System.Drawing.Color.White;
            this.btnOjo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOjo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOjo.FlatAppearance.BorderSize = 0;
            this.btnOjo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnOjo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnOjo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOjo.Location = new System.Drawing.Point(366, 0);
            this.btnOjo.Margin = new System.Windows.Forms.Padding(0);
            this.btnOjo.Name = "btnOjo";
            this.btnOjo.Size = new System.Drawing.Size(34, 26);
            this.btnOjo.TabIndex = 1;
            this.btnOjo.TabStop = false;
            this.btnOjo.UseVisualStyleBackColor = false;
            this.btnOjo.Click += new System.EventHandler(this.btnOjo_Click);
            this.btnOjo.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOjo_Paint);
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
            this.lblConfirmar.Text = "Confirmar contraseña";
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
            this.tlpBotones.Controls.Add(this.btnCrear, 0, 0);
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
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Tan;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(0, 0);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(196, 46);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear usuario";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
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
            // FormCrearUsuario
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(520, 600);
            this.Controls.Add(this.tlpFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear cuenta de usuario";
            this.tlpFondo.ResumeLayout(false);
            this.card.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.tlpContenido.PerformLayout();
            this.tlpClave.ResumeLayout(false);
            this.tlpClave.PerformLayout();
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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TableLayoutPanel tlpClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnOjo;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TableLayoutPanel tlpConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnOjoConfirmar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
    }
}
