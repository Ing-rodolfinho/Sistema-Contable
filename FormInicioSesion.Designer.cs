namespace WindowsFormsApp1
{
    partial class FormInicioSesion
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
            this.cardLogin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.tlpClave = new System.Windows.Forms.TableLayoutPanel();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnOjo = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tlpEnlaces = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.tlpFondo.SuspendLayout();
            this.cardLogin.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpClave.SuspendLayout();
            this.tlpEnlaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFondo
            // 
            this.tlpFondo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tlpFondo.ColumnCount = 3;
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 587F));
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.Controls.Add(this.cardLogin, 1, 1);
            this.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFondo.Location = new System.Drawing.Point(0, 0);
            this.tlpFondo.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.RowCount = 3;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 726F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.Size = new System.Drawing.Size(1200, 837);
            this.tlpFondo.TabIndex = 0;
            // 
            // cardLogin
            // 
            this.cardLogin.BackColor = System.Drawing.Color.Transparent;
            this.cardLogin.Controls.Add(this.tlpContenido);
            this.cardLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardLogin.FillColor = System.Drawing.Color.White;
            this.cardLogin.Location = new System.Drawing.Point(306, 55);
            this.cardLogin.Margin = new System.Windows.Forms.Padding(0);
            this.cardLogin.Name = "cardLogin";
            this.cardLogin.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.cardLogin.Radius = 25;
            this.cardLogin.ShadowColor = System.Drawing.Color.Black;
            this.cardLogin.Size = new System.Drawing.Size(587, 726);
            this.cardLogin.TabIndex = 0;
            // 
            // tlpContenido
            // 
            this.tlpContenido.BackColor = System.Drawing.Color.Transparent;
            this.tlpContenido.ColumnCount = 1;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.picLogo, 0, 0);
            this.tlpContenido.Controls.Add(this.lblTitulo, 0, 1);
            this.tlpContenido.Controls.Add(this.lblSubtitulo, 0, 2);
            this.tlpContenido.Controls.Add(this.lblUsuario, 0, 3);
            this.tlpContenido.Controls.Add(this.txtUsuario, 0, 4);
            this.tlpContenido.Controls.Add(this.lblClave, 0, 5);
            this.tlpContenido.Controls.Add(this.tlpClave, 0, 6);
            this.tlpContenido.Controls.Add(this.lblError, 0, 7);
            this.tlpContenido.Controls.Add(this.btnIniciar, 0, 8);
            this.tlpContenido.Controls.Add(this.btnSalir, 0, 9);
            this.tlpContenido.Controls.Add(this.tlpEnlaces, 0, 10);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(40, 30);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(4);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 12;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(507, 666);
            this.tlpContenido.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2026_10_16_223044;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(507, 178);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(0, 185);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(507, 52);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Inicio de sesión";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Sienna;
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 237);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(507, 25);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Sistema Contable Empresarial";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblUsuario.Location = new System.Drawing.Point(0, 284);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(507, 22);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Nombre de usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtUsuario.Location = new System.Drawing.Point(0, 306);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(507, 32);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblClave
            // 
            this.lblClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblClave.Location = new System.Drawing.Point(0, 358);
            this.lblClave.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(507, 22);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Contraseña";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpClave
            // 
            this.tlpClave.BackColor = System.Drawing.Color.Transparent;
            this.tlpClave.ColumnCount = 2;
            this.tlpClave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpClave.Controls.Add(this.txtClave, 0, 0);
            this.tlpClave.Controls.Add(this.btnOjo, 1, 0);
            this.tlpClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClave.Location = new System.Drawing.Point(0, 380);
            this.tlpClave.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.tlpClave.Name = "tlpClave";
            this.tlpClave.RowCount = 1;
            this.tlpClave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClave.Size = new System.Drawing.Size(507, 35);
            this.tlpClave.TabIndex = 1;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtClave.Location = new System.Drawing.Point(0, 0);
            this.txtClave.Margin = new System.Windows.Forms.Padding(0);
            this.txtClave.MaxLength = 100;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '●';
            this.txtClave.Size = new System.Drawing.Size(462, 32);
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
            this.btnOjo.Location = new System.Drawing.Point(462, 0);
            this.btnOjo.Margin = new System.Windows.Forms.Padding(0);
            this.btnOjo.Name = "btnOjo";
            this.btnOjo.Size = new System.Drawing.Size(45, 35);
            this.btnOjo.TabIndex = 1;
            this.btnOjo.TabStop = false;
            this.btnOjo.UseVisualStyleBackColor = false;
            this.btnOjo.Click += new System.EventHandler(this.btnOjo_Click);
            this.btnOjo.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOjo_Paint);
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(0, 427);
            this.lblError.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(507, 39);
            this.lblError.TabIndex = 7;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Tan;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(0, 481);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(507, 39);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Sienna;
            this.btnSalir.Location = new System.Drawing.Point(0, 530);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(507, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // tlpEnlaces
            // 
            this.tlpEnlaces.BackColor = System.Drawing.Color.Transparent;
            this.tlpEnlaces.ColumnCount = 2;
            this.tlpEnlaces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEnlaces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEnlaces.Controls.Add(this.btnCambiarClave, 0, 0);
            this.tlpEnlaces.Controls.Add(this.btnCrearUsuario, 1, 0);
            this.tlpEnlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEnlaces.Location = new System.Drawing.Point(0, 577);
            this.tlpEnlaces.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tlpEnlaces.Name = "tlpEnlaces";
            this.tlpEnlaces.RowCount = 1;
            this.tlpEnlaces.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEnlaces.Size = new System.Drawing.Size(507, 37);
            this.tlpEnlaces.TabIndex = 4;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCambiarClave.FlatAppearance.BorderSize = 0;
            this.btnCambiarClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnCambiarClave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnCambiarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarClave.ForeColor = System.Drawing.Color.Sienna;
            this.btnCambiarClave.Location = new System.Drawing.Point(0, 0);
            this.btnCambiarClave.Margin = new System.Windows.Forms.Padding(0);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(253, 37);
            this.btnCambiarClave.TabIndex = 0;
            this.btnCambiarClave.Text = "Cambiar contraseña";
            this.btnCambiarClave.UseVisualStyleBackColor = false;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnCrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.Sienna;
            this.btnCrearUsuario.Location = new System.Drawing.Point(253, 0);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(254, 37);
            this.btnCrearUsuario.TabIndex = 1;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // FormInicioSesion
            // 
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1200, 837);
            this.Controls.Add(this.tlpFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.tlpFondo.ResumeLayout(false);
            this.cardLogin.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.tlpContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpClave.ResumeLayout(false);
            this.tlpClave.PerformLayout();
            this.tlpEnlaces.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardLogin;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TableLayoutPanel tlpClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnOjo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tlpEnlaces;
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Button btnCrearUsuario;
    }
}
