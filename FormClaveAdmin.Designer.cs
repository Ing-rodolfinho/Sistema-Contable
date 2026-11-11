namespace WindowsFormsApp1
{
    partial class FormClaveAdmin
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
            this.lblClave = new System.Windows.Forms.Label();
            this.tlpClave = new System.Windows.Forms.TableLayoutPanel();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnOjo = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpFondo.SuspendLayout();
            this.card.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.tlpClave.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFondo
            // 
            this.tlpFondo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tlpFondo.ColumnCount = 3;
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.Controls.Add(this.card, 1, 1);
            this.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFondo.Location = new System.Drawing.Point(0, 0);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.RowCount = 3;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFondo.Size = new System.Drawing.Size(480, 330);
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
            this.card.Padding = new System.Windows.Forms.Padding(26, 18, 26, 18);
            this.card.Radius = 25;
            this.card.ShadowColor = System.Drawing.Color.Black;
            this.card.Size = new System.Drawing.Size(420, 270);
            this.card.TabIndex = 0;
            // 
            // tlpContenido
            // 
            this.tlpContenido.BackColor = System.Drawing.Color.Transparent;
            this.tlpContenido.ColumnCount = 1;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpContenido.Controls.Add(this.lblSubtitulo, 0, 1);
            this.tlpContenido.Controls.Add(this.lblClave, 0, 2);
            this.tlpContenido.Controls.Add(this.tlpClave, 0, 3);
            this.tlpContenido.Controls.Add(this.lblError, 0, 4);
            this.tlpContenido.Controls.Add(this.tlpBotones, 0, 5);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(26, 18);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 7;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(368, 234);
            this.tlpContenido.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(368, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Confirmar administrador";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Sienna;
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 30);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(368, 38);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Ingrese la contraseña del administrador para crear usuarios.";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClave
            // 
            this.lblClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblClave.Location = new System.Drawing.Point(0, 76);
            this.lblClave.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(368, 16);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Contraseña del administrador";
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
            this.tlpClave.Location = new System.Drawing.Point(0, 98);
            this.tlpClave.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.tlpClave.Name = "tlpClave";
            this.tlpClave.RowCount = 1;
            this.tlpClave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClave.Size = new System.Drawing.Size(368, 26);
            this.tlpClave.TabIndex = 3;
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
            this.txtClave.Size = new System.Drawing.Size(334, 26);
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
            this.btnOjo.Location = new System.Drawing.Point(334, 0);
            this.btnOjo.Margin = new System.Windows.Forms.Padding(0);
            this.btnOjo.Name = "btnOjo";
            this.btnOjo.Size = new System.Drawing.Size(34, 26);
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
            this.lblError.Location = new System.Drawing.Point(0, 130);
            this.lblError.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(368, 22);
            this.lblError.TabIndex = 4;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.Transparent;
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnContinuar, 0, 0);
            this.tlpBotones.Controls.Add(this.btnCancelar, 1, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(0, 160);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(368, 40);
            this.tlpBotones.TabIndex = 5;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Tan;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(0, 0);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(180, 40);
            this.btnContinuar.TabIndex = 0;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(188, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormClaveAdmin
            // 
            this.AcceptButton = this.btnContinuar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(480, 330);
            this.Controls.Add(this.tlpFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClaveAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmar administrador";
            this.tlpFondo.ResumeLayout(false);
            this.card.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.tlpContenido.PerformLayout();
            this.tlpClave.ResumeLayout(false);
            this.tlpClave.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private Guna.UI2.WinForms.Guna2ShadowPanel card;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TableLayoutPanel tlpClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnOjo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
