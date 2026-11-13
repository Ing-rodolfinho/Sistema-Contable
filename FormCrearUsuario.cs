using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCrearUsuario : FormBase
    {
        private const char CaracterOculto = '\u25CF';

        private bool claveVisible;
        private bool confirmarVisible;

        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtUsuario.Focus();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string nombre = txtNombre.Text.Trim();

                if (usuario.Length == 0)
                {
                    lblError.Text = "Escriba el nombre de usuario.";
                    txtUsuario.Focus();
                    return;
                }
                if (nombre.Length == 0)
                {
                    lblError.Text = "Escriba el nombre completo del usuario.";
                    txtNombre.Focus();
                    return;
                }
                if (txtClave.Text.Length < Autenticacion.LongitudMinimaClave)
                {
                    lblError.Text = "La contraseña debe tener al menos "
                        + Autenticacion.LongitudMinimaClave + " caracteres.";
                    txtClave.Focus();
                    return;
                }
                if (!string.Equals(txtClave.Text, txtConfirmar.Text, StringComparison.Ordinal))
                {
                    lblError.Text = "Las contraseñas no coinciden.";
                    txtConfirmar.Focus();
                    return;
                }

                string error;
                if (!Autenticacion.CrearUsuario(usuario, nombre, txtClave.Text, out error))
                {
                    lblError.Text = error;
                    return;
                }

                MessageBox.Show("El usuario \"" + usuario + "\" se creó correctamente.",
                    "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ManejadorErrores.Mostrar(ex, "Error al crear el usuario");
            }
        }

        private void btnOjo_Click(object sender, EventArgs e)
        {
            claveVisible = !claveVisible;
            txtClave.PasswordChar = claveVisible ? '\0' : CaracterOculto;
            btnOjo.AccessibleName = claveVisible ? "Ocultar contraseña" : "Mostrar contraseña";
            btnOjo.Invalidate();

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

        private void btnOjoConfirmar_Click(object sender, EventArgs e)
        {
            confirmarVisible = !confirmarVisible;
            txtConfirmar.PasswordChar = confirmarVisible ? '\0' : CaracterOculto;
            btnOjoConfirmar.AccessibleName = confirmarVisible ? "Ocultar contraseña" : "Mostrar contraseña";
            btnOjoConfirmar.Invalidate();

            if (IsHandleCreated)
            {
                BeginInvoke(new Action(() =>
                {
                    txtConfirmar.Focus();
                    txtConfirmar.SelectionStart = txtConfirmar.TextLength;
                    txtConfirmar.SelectionLength = 0;
                }));
            }
        }

        private void btnOjo_Paint(object sender, PaintEventArgs e)
        {
            UiContable.DibujarOjo(e.Graphics, btnOjo.ClientSize, claveVisible);
        }

        private void btnOjoConfirmar_Paint(object sender, PaintEventArgs e)
        {
            UiContable.DibujarOjo(e.Graphics, btnOjoConfirmar.ClientSize, confirmarVisible);
        }
    }
}
