namespace WindowsFormsApp1
{
    partial class FormGenerarLibroMayor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.raiz = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.filtros = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.chkOcultarVacios = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tarjeta = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvMayor = new System.Windows.Forms.DataGridView();
            this.colCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstado = new System.Windows.Forms.Label();
            this.raiz.SuspendLayout();
            this.filtros.SuspendLayout();
            this.tarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayor)).BeginInit();
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
            this.lblTitulo.Size = new System.Drawing.Size(224, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LIBRO MAYOR";
            // 
            // filtros
            // 
            this.filtros.AutoSize = true;
            this.filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filtros.BackColor = System.Drawing.Color.Transparent;
            this.filtros.Controls.Add(this.lblDesde);
            this.filtros.Controls.Add(this.dtpDesde);
            this.filtros.Controls.Add(this.lblHasta);
            this.filtros.Controls.Add(this.dtpHasta);
            this.filtros.Controls.Add(this.lblCuenta);
            this.filtros.Controls.Add(this.cboCuenta);
            this.filtros.Controls.Add(this.chkOcultarVacios);
            this.filtros.Controls.Add(this.btnGenerar);
            this.filtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtros.Location = new System.Drawing.Point(18, 57);
            this.filtros.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(1478, 37);
            this.filtros.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDesde.Location = new System.Drawing.Point(0, 9);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(0, 9, 6, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(61, 23);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(67, 4);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(0, 4, 14, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(112, 30);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.Filtro_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHasta.Location = new System.Drawing.Point(193, 9);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(0, 9, 6, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(57, 23);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(256, 4);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(0, 4, 14, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(112, 30);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.Filtro_ValueChanged);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCuenta.Location = new System.Drawing.Point(382, 9);
            this.lblCuenta.Margin = new System.Windows.Forms.Padding(0, 9, 6, 0);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(69, 23);
            this.lblCuenta.TabIndex = 4;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // cboCuenta
            // 
            this.cboCuenta.BackColor = System.Drawing.Color.White;
            this.cboCuenta.DropDownHeight = 300;
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCuenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuenta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cboCuenta.IntegralHeight = false;
            this.cboCuenta.Location = new System.Drawing.Point(457, 4);
            this.cboCuenta.Margin = new System.Windows.Forms.Padding(0, 4, 14, 0);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(330, 31);
            this.cboCuenta.TabIndex = 5;
            this.cboCuenta.SelectedIndexChanged += new System.EventHandler(this.Filtro_ValueChanged);
            // 
            // chkOcultarVacios
            // 
            this.chkOcultarVacios.AutoSize = true;
            this.chkOcultarVacios.Checked = true;
            this.chkOcultarVacios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOcultarVacios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOcultarVacios.ForeColor = System.Drawing.Color.SaddleBrown;
            this.chkOcultarVacios.Location = new System.Drawing.Point(803, 9);
            this.chkOcultarVacios.Margin = new System.Windows.Forms.Padding(2, 9, 14, 0);
            this.chkOcultarVacios.Name = "chkOcultarVacios";
            this.chkOcultarVacios.Size = new System.Drawing.Size(345, 27);
            this.chkOcultarVacios.TabIndex = 6;
            this.chkOcultarVacios.Text = "Ocultar cuentas sin saldo ni movimientos";
            this.chkOcultarVacios.UseVisualStyleBackColor = true;
            this.chkOcultarVacios.CheckedChanged += new System.EventHandler(this.Filtro_ValueChanged);
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
            this.btnGenerar.Location = new System.Drawing.Point(1162, 4);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(0, 4, 10, 0);
            this.btnGenerar.MinimumSize = new System.Drawing.Size(118, 32);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGenerar.Size = new System.Drawing.Size(194, 33);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar libro mayor";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tarjeta
            // 
            this.tarjeta.BackColor = System.Drawing.Color.Transparent;
            this.tarjeta.Controls.Add(this.dgvMayor);
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
            // dgvMayor
            // 
            this.dgvMayor.AllowUserToAddRows = false;
            this.dgvMayor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvMayor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMayor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMayor.BackgroundColor = System.Drawing.Color.White;
            this.dgvMayor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMayor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMayor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMayor.ColumnHeadersHeight = 42;
            this.dgvMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMayor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCuenta,
            this.colFecha,
            this.colReferencia,
            this.colConcepto,
            this.colDebe,
            this.colHaber,
            this.colSaldo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMayor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMayor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMayor.EnableHeadersVisualStyles = false;
            this.dgvMayor.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvMayor.Location = new System.Drawing.Point(10, 10);
            this.dgvMayor.MultiSelect = false;
            this.dgvMayor.Name = "dgvMayor";
            this.dgvMayor.ReadOnly = true;
            this.dgvMayor.RowHeadersVisible = false;
            this.dgvMayor.RowHeadersWidth = 51;
            this.dgvMayor.RowTemplate.Height = 26;
            this.dgvMayor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMayor.Size = new System.Drawing.Size(1458, 759);
            this.dgvMayor.TabIndex = 0;
            // 
            // colCuenta
            // 
            this.colCuenta.FillWeight = 125F;
            this.colCuenta.HeaderText = "Cuenta";
            this.colCuenta.MinimumWidth = 55;
            this.colCuenta.Name = "colCuenta";
            this.colCuenta.ReadOnly = true;
            this.colCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 60F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 92;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colReferencia
            // 
            this.colReferencia.FillWeight = 75F;
            this.colReferencia.HeaderText = "Referencia";
            this.colReferencia.MinimumWidth = 55;
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.ReadOnly = true;
            this.colReferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colConcepto
            // 
            this.colConcepto.FillWeight = 145F;
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.MinimumWidth = 55;
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.ReadOnly = true;
            this.colConcepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDebe
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDebe.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDebe.FillWeight = 68F;
            this.colDebe.HeaderText = "Debe";
            this.colDebe.MinimumWidth = 55;
            this.colDebe.Name = "colDebe";
            this.colDebe.ReadOnly = true;
            this.colDebe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colHaber
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colHaber.DefaultCellStyle = dataGridViewCellStyle4;
            this.colHaber.FillWeight = 68F;
            this.colHaber.HeaderText = "Haber";
            this.colHaber.MinimumWidth = 55;
            this.colHaber.Name = "colHaber";
            this.colHaber.ReadOnly = true;
            this.colHaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSaldo
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSaldo.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSaldo.FillWeight = 78F;
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.MinimumWidth = 55;
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            this.colSaldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // FormGenerarLibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1514, 925);
            this.Controls.Add(this.raiz);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGenerarLibroMayor";
            this.Text = "Libro Mayor";
            this.raiz.ResumeLayout(false);
            this.raiz.PerformLayout();
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            this.tarjeta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel raiz;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel filtros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.CheckBox chkOcultarVacios;
        private System.Windows.Forms.Button btnGenerar;
        private Guna.UI2.WinForms.Guna2ShadowPanel tarjeta;
        private System.Windows.Forms.DataGridView dgvMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.Label lblEstado;
    }
}
