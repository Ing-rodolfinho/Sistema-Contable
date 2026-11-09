namespace WindowsFormsApp1
{
    partial class FormGenerarBalanceGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.raiz = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.filtros = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tarjeta = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvBalance = new System.Windows.Forms.DataGridView();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstado = new System.Windows.Forms.Label();
            this.raiz.SuspendLayout();
            this.filtros.SuspendLayout();
            this.tarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // raiz
            // 
            this.raiz.BackColor = System.Drawing.Color.LavenderBlush;
            this.raiz.ColumnCount = 1;
            this.raiz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.raiz.Controls.Add(this.lblTitulo, 0, 0);
            this.raiz.Controls.Add(this.filtros, 0, 1);
            this.raiz.Controls.Add(this.tarjeta, 0, 2);
            this.raiz.Controls.Add(this.lblEstado, 0, 3);
            this.raiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raiz.Location = new System.Drawing.Point(0, 0);
            this.raiz.Margin = new System.Windows.Forms.Padding(0);
            this.raiz.Name = "raiz";
            this.raiz.Padding = new System.Windows.Forms.Padding(18, 10, 18, 8);
            this.raiz.RowCount = 4;
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.raiz.Size = new System.Drawing.Size(1514, 925);
            this.raiz.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 4, 0, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(306, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BALANCE GENERAL";
            // 
            // filtros
            // 
            this.filtros.AutoSize = true;
            this.filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filtros.BackColor = System.Drawing.Color.Transparent;
            this.filtros.Controls.Add(this.lblFecha);
            this.filtros.Controls.Add(this.dtpFecha);
            this.filtros.Controls.Add(this.btnGenerar);
            this.filtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtros.Location = new System.Drawing.Point(18, 57);
            this.filtros.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(1478, 37);
            this.filtros.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFecha.Location = new System.Drawing.Point(0, 9);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(0, 9, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(29, 23);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Al:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(35, 4);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(0, 4, 14, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(112, 30);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.Filtro_ValueChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerar.BackColor = System.Drawing.Color.Tan;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(161, 4);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(0, 4, 10, 0);
            this.btnGenerar.MinimumSize = new System.Drawing.Size(118, 32);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGenerar.Size = new System.Drawing.Size(165, 33);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar balance";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tarjeta
            // 
            this.tarjeta.BackColor = System.Drawing.Color.Transparent;
            this.tarjeta.Controls.Add(this.dgvBalance);
            this.tarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta.FillColor = System.Drawing.Color.White;
            this.tarjeta.Location = new System.Drawing.Point(18, 104);
            this.tarjeta.Margin = new System.Windows.Forms.Padding(0);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Padding = new System.Windows.Forms.Padding(10);
            this.tarjeta.Radius = 15;
            this.tarjeta.ShadowColor = System.Drawing.Color.Black;
            this.tarjeta.Size = new System.Drawing.Size(1478, 779);
            this.tarjeta.TabIndex = 2;
            // 
            // dgvBalance
            // 
            this.dgvBalance.AllowUserToAddRows = false;
            this.dgvBalance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBalance.BackgroundColor = System.Drawing.Color.White;
            this.dgvBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBalance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBalance.ColumnHeadersHeight = 42;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConcepto,
            this.colImporte});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBalance.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBalance.EnableHeadersVisualStyles = false;
            this.dgvBalance.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvBalance.Location = new System.Drawing.Point(10, 10);
            this.dgvBalance.MultiSelect = false;
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.ReadOnly = true;
            this.dgvBalance.RowHeadersVisible = false;
            this.dgvBalance.RowHeadersWidth = 51;
            this.dgvBalance.RowTemplate.Height = 26;
            this.dgvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalance.Size = new System.Drawing.Size(1458, 759);
            this.dgvBalance.TabIndex = 0;
            // 
            // colConcepto
            // 
            this.colConcepto.FillWeight = 300F;
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.MinimumWidth = 55;
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.ReadOnly = true;
            this.colConcepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colImporte
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.colImporte.FillWeight = 110F;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.MinimumWidth = 55;
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            this.colImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoEllipsis = true;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEstado.Location = new System.Drawing.Point(20, 889);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(1474, 28);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormGenerarBalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1514, 925);
            this.Controls.Add(this.raiz);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGenerarBalanceGeneral";
            this.Text = "Balance General";
            this.raiz.ResumeLayout(false);
            this.raiz.PerformLayout();
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            this.tarjeta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel raiz;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel filtros;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGenerar;
        private Guna.UI2.WinForms.Guna2ShadowPanel tarjeta;
        private System.Windows.Forms.DataGridView dgvBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Label lblEstado;
    }
}
