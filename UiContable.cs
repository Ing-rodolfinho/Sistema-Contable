using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class UiContable
    {
        public static readonly Color Fondo = Color.LavenderBlush;
        public static readonly Color Tarjeta = Color.White;
        public static readonly Color Acento = Color.SaddleBrown;
        public static readonly Color AcentoMedio = Color.Tan;
        public static readonly Color AcentoFuerte = Color.Sienna;
        public static readonly Color Rosa = Color.LightPink;
        public static readonly Color RosaSuave = Color.MistyRose;
        public static readonly Color EncabezadoTabla = Color.FromArgb(245, 230, 220);
        public static readonly Color Texto = Color.SaddleBrown;
        public static readonly Color Positivo = Color.SeaGreen;
        public static readonly Color Negativo = Color.Firebrick;

        public static Font Fuente(float tamano)
        {
            return new Font("Segoe UI", tamano, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static Font FuenteNegrita(float tamano)
        {
            return new Font("Segoe UI Semibold", tamano, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static Label CrearTitulo(string texto)
        {
            var etiqueta = new Label();
            etiqueta.AutoSize = true;
            etiqueta.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            etiqueta.ForeColor = Acento;
            etiqueta.Text = texto;
            etiqueta.Margin = new Padding(0);
            return etiqueta;
        }

        public static Label Etiqueta(string texto)
        {
            var etiqueta = new Label();
            etiqueta.AutoSize = true;
            etiqueta.Font = Fuente(10F);
            etiqueta.ForeColor = Texto;
            etiqueta.Text = texto;
            etiqueta.Margin = new Padding(0, 9, 6, 0);
            return etiqueta;
        }

        public static Label CrearEstado()
        {
            var etiqueta = new Label();
            etiqueta.AutoSize = false;
            etiqueta.AutoEllipsis = true;
            etiqueta.Dock = DockStyle.Fill;
            etiqueta.Height = 28;
            etiqueta.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic, GraphicsUnit.Point);
            etiqueta.ForeColor = Acento;
            etiqueta.TextAlign = ContentAlignment.MiddleLeft;
            etiqueta.Margin = new Padding(2, 6, 2, 0);
            return etiqueta;
        }

        public static FlowLayoutPanel CrearBarra()
        {
            var barra = new FlowLayoutPanel();
            barra.Dock = DockStyle.Fill;
            barra.AutoSize = true;
            barra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            barra.WrapContents = true;
            barra.FlowDirection = FlowDirection.LeftToRight;
            barra.BackColor = Color.Transparent;
            barra.Margin = new Padding(0, 0, 0, 10);
            barra.Padding = new Padding(0);
            return barra;
        }

        public static DateTimePicker CrearFecha(DateTime valor)
        {
            var selector = new DateTimePicker();
            selector.Format = DateTimePickerFormat.Short;
            selector.Font = Fuente(10F);
            selector.Width = 112;
            selector.Value = valor;
            selector.Margin = new Padding(0, 4, 14, 0);
            return selector;
        }

        public static ComboBox CrearCombo(int ancho)
        {
            var combo = new ComboBox();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.FlatStyle = FlatStyle.Flat;
            combo.BackColor = Color.White;
            combo.ForeColor = Texto;
            combo.Font = Fuente(10F);
            combo.Width = ancho;
            combo.IntegralHeight = false;
            combo.DropDownHeight = 300;
            combo.Margin = new Padding(0, 4, 14, 0);
            return combo;
        }

        public static TextBox CrearTexto(int ancho)
        {
            var caja = new TextBox();
            caja.BorderStyle = BorderStyle.FixedSingle;
            caja.BackColor = Color.White;
            caja.ForeColor = Texto;
            caja.Font = Fuente(10F);
            caja.Width = ancho;
            caja.Margin = new Padding(0, 4, 14, 0);
            return caja;
        }

        public static Button CrearBoton(string texto, EventHandler accion)
        {
            var boton = new Button();
            boton.Text = texto;
            boton.AutoSize = true;
            boton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            boton.MinimumSize = new Size(118, 32);
            boton.Padding = new Padding(10, 0, 10, 0);
            boton.Height = 32;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor = Acento;
            boton.FlatAppearance.MouseDownBackColor = AcentoFuerte;
            boton.BackColor = AcentoMedio;
            boton.ForeColor = Color.White;
            boton.Font = FuenteNegrita(10F);
            boton.Cursor = Cursors.Hand;
            boton.Margin = new Padding(0, 4, 10, 0);
            boton.UseVisualStyleBackColor = false;
            if (accion != null) boton.Click += accion;
            return boton;
        }

        public static CheckBox CrearCheck(string texto, bool marcado)
        {
            var check = new CheckBox();
            check.Text = texto;
            check.AutoSize = true;
            check.Checked = marcado;
            check.ForeColor = Texto;
            check.Font = Fuente(10F);
            check.Margin = new Padding(2, 9, 14, 0);
            check.UseVisualStyleBackColor = true;
            return check;
        }

        public static DataGridView CrearGrid()
        {
            var grid = new DataGridView();
            grid.Dock = DockStyle.Fill;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = true;
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = Color.Gainsboro;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.RowTemplate.Height = 26;

            var estiloEncabezado = new DataGridViewCellStyle();
            estiloEncabezado.BackColor = EncabezadoTabla;
            estiloEncabezado.ForeColor = Acento;
            estiloEncabezado.Font = FuenteNegrita(10F);
            estiloEncabezado.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloEncabezado.SelectionBackColor = EncabezadoTabla;
            estiloEncabezado.SelectionForeColor = Acento;
            estiloEncabezado.WrapMode = DataGridViewTriState.True;
            grid.ColumnHeadersDefaultCellStyle = estiloEncabezado;

            var estiloCuerpo = new DataGridViewCellStyle();
            estiloCuerpo.BackColor = Color.White;
            estiloCuerpo.ForeColor = Color.FromArgb(64, 48, 40);
            estiloCuerpo.SelectionBackColor = RosaSuave;
            estiloCuerpo.SelectionForeColor = Acento;
            estiloCuerpo.Font = Fuente(10F);
            grid.DefaultCellStyle = estiloCuerpo;

            var estiloAlterno = new DataGridViewCellStyle();
            estiloAlterno.BackColor = Color.FromArgb(255, 250, 251);
            grid.AlternatingRowsDefaultCellStyle = estiloAlterno;

            return grid;
        }

        public static DataGridViewTextBoxColumn Columna(string nombre, string encabezado, float peso, bool derecha, int anchoMinimo = 55)
        {
            var columna = new DataGridViewTextBoxColumn();
            columna.Name = nombre;
            columna.HeaderText = encabezado;
            columna.FillWeight = peso;
            columna.MinimumWidth = anchoMinimo;
            columna.ReadOnly = true;
            columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            if (derecha)
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            return columna;
        }

        public static Control CrearTarjeta(Control contenido)
        {
            var panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panel.Dock = DockStyle.Fill;
            panel.FillColor = Color.White;
            panel.BackColor = Color.Transparent;
            panel.Radius = 15;
            panel.Padding = new Padding(10);
            panel.Margin = new Padding(0);
            panel.ShadowColor = Color.Black;

            if (contenido != null)
            {
                contenido.Dock = DockStyle.Fill;
                panel.Controls.Add(contenido);
            }

            return panel;
        }

        public static TableLayoutPanel CrearRaiz(Form formulario, string titulo)
        {
            var raiz = new TableLayoutPanel();
            raiz.Dock = DockStyle.Fill;
            raiz.BackColor = Fondo;
            raiz.ColumnCount = 1;
            raiz.RowCount = 4;
            raiz.Padding = new Padding(18, 10, 18, 8);
            raiz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            raiz.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            raiz.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            raiz.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            raiz.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Label etiquetaTitulo = CrearTitulo(titulo);
            etiquetaTitulo.Margin = new Padding(0, 4, 0, 8);
            raiz.Controls.Add(etiquetaTitulo, 0, 0);

            formulario.Controls.Add(raiz);
            return raiz;
        }

        public static void AgregarContenido(TableLayoutPanel raiz, Control contenido)
        {
            if (raiz == null || contenido == null) return;
            raiz.Controls.Add(contenido, 0, 2);
        }

        /// <summary>
        /// Dibuja el icono de ojo (abierto o tachado) que usan los campos de contraseña.
        /// </summary>
        public static void DibujarOjo(Graphics g, Size tamano, bool claveVisible)
        {
            if (g == null) return;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            int ancho = Math.Min(tamano.Width, tamano.Height) - 12;
            if (ancho < 10) ancho = 10;

            int alto = Math.Max(8, ancho / 2);
            int cx = tamano.Width / 2;
            int cy = tamano.Height / 2;
            int izquierda = cx - ancho / 2;
            int arriba = cy - alto / 2;

            using (GraphicsPath ojo = new GraphicsPath())
            using (Pen lapiz = new Pen(Acento, 1.6f))
            using (SolidBrush relleno = new SolidBrush(Acento))
            {
                ojo.AddBezier(izquierda, cy, izquierda + ancho / 4, arriba,
                    izquierda + ancho * 3 / 4, arriba, izquierda + ancho, cy);
                ojo.AddBezier(izquierda + ancho, cy, izquierda + ancho * 3 / 4, arriba + alto,
                    izquierda + ancho / 4, arriba + alto, izquierda, cy);

                g.DrawPath(lapiz, ojo);

                int radio = Math.Max(2, alto / 4);
                g.FillEllipse(relleno, cx - radio, cy - radio, radio * 2, radio * 2);

                if (!claveVisible)
                {
                    g.DrawLine(lapiz, izquierda - 1, arriba + alto + 1,
                        izquierda + ancho + 1, arriba - 1);
                }
            }
        }

        public static void EstilizarFila(DataGridViewRow fila, bool negrita, Color? fondo)
        {
            if (fila == null) return;

            foreach (DataGridViewCell celda in fila.Cells)
            {
                celda.Style.Font = negrita ? FuenteNegrita(10F) : Fuente(10F);
                if (fondo.HasValue) celda.Style.BackColor = fondo.Value;
            }
        }
    }
}
