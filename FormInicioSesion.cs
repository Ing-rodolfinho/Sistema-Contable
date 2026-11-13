using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInicioSesion : FormBase
    {
        private const char CaracterOculto = '\u25CF';

        private bool claveVisible;

        /// <summary>
        /// Usuario que inició sesión correctamente.
        /// </summary>
        public UsuarioSesion UsuarioAutenticado { get; private set; }

        public FormInicioSesion()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtUsuario.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string clave = txtClave.Text;

                if (usuario.Length == 0)
                {
                    lblError.Text = "Escriba el nombre de usuario.";
                    txtUsuario.Focus();
                    return;
                }
                if (clave.Length == 0)
                {
                    lblError.Text = "Escriba la contraseña.";
                    txtClave.Focus();
                    return;
                }

                UsuarioSesion sesion;
                string error;

                if (!Autenticacion.IniciarSesion(usuario, clave, out sesion, out error))
                {
                    txtClave.Clear();
                    claveVisible = false;
                    AplicarVisibilidadClave();
                    lblError.Text = error;
                    txtClave.Focus();
                    return;
                }

                UsuarioAutenticado = sesion;
                lblError.Text = string.Empty;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ManejadorErrores.Mostrar(ex, "Error al iniciar sesión");
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            using (var cambiar = new FormCambiarClave(txtUsuario.Text))
            {
                cambiar.ShowDialog(this);
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            using (var claveAdmin = new FormClaveAdmin())
            {
                if (claveAdmin.ShowDialog(this) != DialogResult.OK) return;
            }

            using (var crear = new FormCrearUsuario())
            {
                crear.ShowDialog(this);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void btnOjo_Click(object sender, EventArgs e)
        {
            claveVisible = !claveVisible;
            AplicarVisibilidadClave();

            // El foco se devuelve al campo después de que termine el clic;
            // hacerlo dentro del evento puede hacer que el siguiente clic se pierda.
            if (IsHandleCreated)
            {
                BeginInvoke(new Action(() =>
                {
                    txtClave.Focus();
                    txtClave.SelectionStart = txtClave.TextLength;
                    txtClave.SelectionLength = 0;
                }));
            }
        }

        private void AplicarVisibilidadClave()
        {
            // Se usa PasswordChar en lugar de UseSystemPasswordChar porque, en este
            // entorno, cambiar UseSystemPasswordChar recrea el handle nativo del
            // TextBox y el carácter de contraseña deja de aplicarse tras el primer clic.
            txtClave.PasswordChar = claveVisible ? '\0' : CaracterOculto;

            string descripcion = claveVisible ? "Ocultar contraseña" : "Mostrar contraseña";
            btnOjo.AccessibleName = descripcion;
            btnOjo.Invalidate();
        }

        private void btnOjo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int ancho = Math.Min(btnOjo.ClientSize.Width, btnOjo.ClientSize.Height) - 12;
            if (ancho < 10) ancho = 10;

            int alto = Math.Max(8, ancho / 2);
            int cx = btnOjo.ClientSize.Width / 2;
            int cy = btnOjo.ClientSize.Height / 2;
            int izquierda = cx - ancho / 2;
            int arriba = cy - alto / 2;

            using (GraphicsPath ojo = new GraphicsPath())
            using (Pen lapiz = new Pen(Color.SaddleBrown, 1.6f))
            using (SolidBrush relleno = new SolidBrush(Color.SaddleBrown))
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
    }
}
