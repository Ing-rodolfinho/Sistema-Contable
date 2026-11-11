using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCambiarClave : FormBase
    {
        private const char CaracterOculto = '\u25CF';

        private bool actualVisible;
        private bool nuevaVisible;
        private bool confirmarVisible;

        public FormCambiarClave()
            : this(string.Empty)
        {
        }

        public FormCambiarClave(string usuarioInicial)
        {
            InitializeComponent();
            txtUsuario.Text = usuarioInicial ?? string.Empty;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (txtUsuario.Text.Trim().Length == 0)
                txtUsuario.Focus();
            else
                txtActual.Focus();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtActual_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtNueva_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (!string.Equals(txtNueva.Text, txtConfirmar.Text, StringComparison.Ordinal))
            {
                lblError.Text = "La nueva contraseña y su confirmación no coinciden.";
                txtConfirmar.Focus();
                return;
            }

            string error;
            if (!Autenticacion.CambiarClave(txtUsuario.Text, txtActual.Text, txtNueva.Text, out error))
            {
                lblError.Text = error;
                return;
            }

            MessageBox.Show("La contraseña se cambió correctamente.", "Contraseña actualizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOjoActual_Click(object sender, EventArgs e)
        {
            actualVisible = !actualVisible;
            txtActual.PasswordChar = actualVisible ? '\0' : CaracterOculto;
            btnOjoActual.AccessibleName = actualVisible ? "Ocultar contraseña" : "Mostrar contraseña";
            btnOjoActual.Invalidate();

            DevolverFoco(txtActual);
        }

        private void btnOjoNueva_Click(object sender, EventArgs e)
        {
            nuevaVisible = !nuevaVisible;
            txtNueva.PasswordChar = nuevaVisible ? '\0' : CaracterOculto;
            btnOjoNueva.AccessibleName = nuevaVisible ? "Ocultar contraseña" : "Mostrar contraseña";
            btnOjoNueva.Invalidate();

            DevolverFoco(txtNueva);
        }

        private void btnOjoConfirmar_Click(object sender, EventArgs e)
        {
            confirmarVisible = !confirmarVisible;
            txtConfirmar.PasswordChar = confirmarVisible ? '\0' : CaracterOculto;
            btnOjoConfirmar.AccessibleName = confirmarVisible ? "Ocultar contraseña" : "Mostrar contraseña";
            btnOjoConfirmar.Invalidate();

            DevolverFoco(txtConfirmar);
        }

        private void DevolverFoco(TextBox campo)
        {
            if (!IsHandleCreated) return;

            BeginInvoke(new Action(() =>
            {
                campo.Focus();
                campo.SelectionStart = campo.TextLength;
                campo.SelectionLength = 0;
            }));
        }

        private void btnOjoActual_Paint(object sender, PaintEventArgs e)
        {
            UiContable.DibujarOjo(e.Graphics, btnOjoActual.ClientSize, actualVisible);
        }

        private void btnOjoNueva_Paint(object sender, PaintEventArgs e)
        {
            UiContable.DibujarOjo(e.Graphics, btnOjoNueva.ClientSize, nuevaVisible);
        }

        private void btnOjoConfirmar_Paint(object sender, PaintEventArgs e)
        {
            UiContable.DibujarOjo(e.Graphics, btnOjoConfirmar.ClientSize, confirmarVisible);
        }
    }
}
