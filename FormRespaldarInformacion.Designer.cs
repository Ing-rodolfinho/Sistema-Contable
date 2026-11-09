namespace WindowsFormsApp1
{
    partial class FormRespaldarInformacion
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
            this.acciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnAbrirCarpeta = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.contenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.tarjeta = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvRespaldos = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarpeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstado = new System.Windows.Forms.Label();
            this.raiz.SuspendLayout();
            this.acciones.SuspendLayout();
            this.contenido.SuspendLayout();
            this.tarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespaldos)).BeginInit();
            this.SuspendLayout();
            // 
            // raiz
            // 
            this.raiz.BackColor = System.Drawing.Color.LavenderBlush;
            this.raiz.ColumnCount = 1;
            this.raiz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.raiz.Controls.Add(this.lblTitulo, 0, 0);
            this.raiz.Controls.Add(this.acciones, 0, 1);
            this.raiz.Controls.Add(this.contenido, 0, 2);
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
            this.lblTitulo.Size = new System.Drawing.Size(419, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RESPALDAR INFORMACIÓN";
            // 
            // acciones
            // 
            this.acciones.AutoSize = true;
            this.acciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.acciones.BackColor = System.Drawing.Color.Transparent;
            this.acciones.Controls.Add(this.btnCrear);
            this.acciones.Controls.Add(this.btnRestaurar);
            this.acciones.Controls.Add(this.btnAbrirCarpeta);
            this.acciones.Controls.Add(this.btnActualizar);
            this.acciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acciones.Location = new System.Drawing.Point(18, 57);
            this.acciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.acciones.Name = "acciones";
            this.acciones.Size = new System.Drawing.Size(1478, 37);
            this.acciones.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.AutoSize = true;
            this.btnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrear.BackColor = System.Drawing.Color.Tan;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(0, 4);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0, 4, 10, 0);
            this.btnCrear.MinimumSize = new System.Drawing.Size(118, 32);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCrear.Size = new System.Drawing.Size(151, 33);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear respaldo";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.AutoSize = true;
            this.btnRestaurar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestaurar.BackColor = System.Drawing.Color.Tan;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Location = new System.Drawing.Point(161, 4);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(0, 4, 10, 0);
            this.btnRestaurar.MinimumSize = new System.Drawing.Size(118, 32);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnRestaurar.Size = new System.Drawing.Size(216, 33);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar seleccionado";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnAbrirCarpeta
            // 
            this.btnAbrirCarpeta.AutoSize = true;
            this.btnAbrirCarpeta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbrirCarpeta.BackColor = System.Drawing.Color.Tan;
            this.btnAbrirCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCarpeta.FlatAppearance.BorderSize = 0;
            this.btnAbrirCarpeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnAbrirCarpeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnAbrirCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCarpeta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCarpeta.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCarpeta.Location = new System.Drawing.Point(387, 4);
            this.btnAbrirCarpeta.Margin = new System.Windows.Forms.Padding(0, 4, 10, 0);
            this.btnAbrirCarpeta.MinimumSize = new System.Drawing.Size(118, 32);
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(240, 33);
            this.btnAbrirCarpeta.TabIndex = 2;
            this.btnAbrirCarpeta.Text = "Abrir carpeta de respaldos";
            this.btnAbrirCarpeta.UseVisualStyleBackColor = false;
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.BackColor = System.Drawing.Color.Tan;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(637, 4);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0, 4, 10, 0);
            this.btnActualizar.MinimumSize = new System.Drawing.Size(118, 32);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnActualizar.Size = new System.Drawing.Size(118, 33);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // contenido
            // 
            this.contenido.ColumnCount = 1;
            this.contenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contenido.Controls.Add(this.lblResumen, 0, 0);
            this.contenido.Controls.Add(this.tarjeta, 0, 1);
            this.contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenido.Location = new System.Drawing.Point(21, 107);
            this.contenido.Name = "contenido";
            this.contenido.RowCount = 2;
            this.contenido.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contenido.Size = new System.Drawing.Size(1472, 773);
            this.contenido.TabIndex = 2;
            // 
            // lblResumen
            // 
            this.lblResumen.BackColor = System.Drawing.Color.White;
            this.lblResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblResumen.Location = new System.Drawing.Point(0, 0);
            this.lblResumen.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.lblResumen.Size = new System.Drawing.Size(1472, 96);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tarjeta
            // 
            this.tarjeta.BackColor = System.Drawing.Color.Transparent;
            this.tarjeta.Controls.Add(this.dgvRespaldos);
            this.tarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta.FillColor = System.Drawing.Color.White;
            this.tarjeta.Location = new System.Drawing.Point(0, 106);
            this.tarjeta.Margin = new System.Windows.Forms.Padding(0);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Padding = new System.Windows.Forms.Padding(10);
            this.tarjeta.Radius = 15;
            this.tarjeta.ShadowColor = System.Drawing.Color.Black;
            this.tarjeta.Size = new System.Drawing.Size(1472, 667);
            this.tarjeta.TabIndex = 1;
            // 
            // dgvRespaldos
            // 
            this.dgvRespaldos.AllowUserToAddRows = false;
            this.dgvRespaldos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvRespaldos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRespaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRespaldos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRespaldos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRespaldos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRespaldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRespaldos.ColumnHeadersHeight = 42;
            this.dgvRespaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRespaldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colCarpeta,
            this.colCuentas,
            this.colOperaciones,
            this.colTamano});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRespaldos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRespaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRespaldos.EnableHeadersVisualStyles = false;
            this.dgvRespaldos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvRespaldos.Location = new System.Drawing.Point(10, 10);
            this.dgvRespaldos.MultiSelect = false;
            this.dgvRespaldos.Name = "dgvRespaldos";
            this.dgvRespaldos.ReadOnly = true;
            this.dgvRespaldos.RowHeadersVisible = false;
            this.dgvRespaldos.RowHeadersWidth = 51;
            this.dgvRespaldos.RowTemplate.Height = 26;
            this.dgvRespaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRespaldos.Size = new System.Drawing.Size(1452, 647);
            this.dgvRespaldos.TabIndex = 0;
            this.dgvRespaldos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRespaldos_CellDoubleClick);
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 130F;
            this.colFecha.HeaderText = "Fecha del respaldo";
            this.colFecha.MinimumWidth = 55;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCarpeta
            // 
            this.colCarpeta.FillWeight = 260F;
            this.colCarpeta.HeaderText = "Carpeta";
            this.colCarpeta.MinimumWidth = 55;
            this.colCarpeta.Name = "colCarpeta";
            this.colCarpeta.ReadOnly = true;
            this.colCarpeta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCuentas
            // 
            this.colCuentas.FillWeight = 90F;
            this.colCuentas.HeaderText = "Cuentas";
            this.colCuentas.MinimumWidth = 55;
            this.colCuentas.Name = "colCuentas";
            this.colCuentas.ReadOnly = true;
            this.colCuentas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colOperaciones
            // 
            this.colOperaciones.HeaderText = "Operaciones";
            this.colOperaciones.MinimumWidth = 55;
            this.colOperaciones.Name = "colOperaciones";
            this.colOperaciones.ReadOnly = true;
            this.colOperaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTamano
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTamano.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTamano.FillWeight = 90F;
            this.colTamano.HeaderText = "Tamaño";
            this.colTamano.MinimumWidth = 55;
            this.colTamano.Name = "colTamano";
            this.colTamano.ReadOnly = true;
            this.colTamano.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // FormRespaldarInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1514, 925);
            this.Controls.Add(this.raiz);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRespaldarInformacion";
            this.Text = "Respaldar Información";
            this.raiz.ResumeLayout(false);
            this.raiz.PerformLayout();
            this.acciones.ResumeLayout(false);
            this.acciones.PerformLayout();
            this.contenido.ResumeLayout(false);
            this.tarjeta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespaldos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel raiz;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel acciones;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnAbrirCarpeta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TableLayoutPanel contenido;
        private System.Windows.Forms.Label lblResumen;
        private Guna.UI2.WinForms.Guna2ShadowPanel tarjeta;
        private System.Windows.Forms.DataGridView dgvRespaldos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarpeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamano;
        private System.Windows.Forms.Label lblEstado;
    }
}
