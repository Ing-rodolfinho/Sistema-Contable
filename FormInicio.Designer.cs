namespace WindowsFormsApp1
{
    partial class FormInicio
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
            this.guna2ShadowPanelInicio = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.picLogoInicio = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelParrafo = new System.Windows.Forms.Label();
            this.tlpFondo.SuspendLayout();
            this.guna2ShadowPanelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFondo
            // 
            this.tlpFondo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tlpFondo.ColumnCount = 1;
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.Controls.Add(this.guna2ShadowPanelInicio, 0, 1);
            this.tlpFondo.Controls.Add(this.labelTitulo, 0, 2);
            this.tlpFondo.Controls.Add(this.labelParrafo, 0, 3);
            this.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFondo.Location = new System.Drawing.Point(0, 0);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.RowCount = 5;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.Size = new System.Drawing.Size(1085, 699);
            this.tlpFondo.TabIndex = 0;
            // 
            // guna2ShadowPanelInicio
            // 
            this.guna2ShadowPanelInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ShadowPanelInicio.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanelInicio.Controls.Add(this.picLogoInicio);
            this.guna2ShadowPanelInicio.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanelInicio.Location = new System.Drawing.Point(372, 80);
            this.guna2ShadowPanelInicio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 28);
            this.guna2ShadowPanelInicio.Name = "guna2ShadowPanelInicio";
            this.guna2ShadowPanelInicio.Radius = 25;
            this.guna2ShadowPanelInicio.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanelInicio.Size = new System.Drawing.Size(340, 270);
            this.guna2ShadowPanelInicio.TabIndex = 0;
            // 
            // picLogoInicio
            // 
            this.picLogoInicio.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicio.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2026_10_16_223044;
            this.picLogoInicio.ImageRotate = 0F;
            this.picLogoInicio.Location = new System.Drawing.Point(20, 15);
            this.picLogoInicio.Name = "picLogoInicio";
            this.picLogoInicio.Size = new System.Drawing.Size(300, 240);
            this.picLogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoInicio.TabIndex = 0;
            this.picLogoInicio.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTitulo.Location = new System.Drawing.Point(282, 385);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(521, 41);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "SISTEMA CONTABLE EMPRESARIAL";
            // 
            // labelParrafo
            // 
            this.labelParrafo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelParrafo.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParrafo.ForeColor = System.Drawing.Color.Sienna;
            this.labelParrafo.Location = new System.Drawing.Point(163, 444);
            this.labelParrafo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.labelParrafo.Name = "labelParrafo";
            this.labelParrafo.Size = new System.Drawing.Size(760, 105);
            this.labelParrafo.TabIndex = 2;
            this.labelParrafo.Text = "Sistema diseñado para gestionar el control contable de la empresa de forma ord" +
    "enada y confiable: administrar cuentas, registrar operaciones, generar el libro " +
    "diario y el libro mayor, elaborar la balanza de comprobación, el balance general" +
    " y los estados de resultados, y respaldar la información.";
            this.labelParrafo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 699);
            this.Controls.Add(this.tlpFondo);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.tlpFondo.ResumeLayout(false);
            this.tlpFondo.PerformLayout();
            this.guna2ShadowPanelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanelInicio;
        private Guna.UI2.WinForms.Guna2PictureBox picLogoInicio;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelParrafo;
    }
}
