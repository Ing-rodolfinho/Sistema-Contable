using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormClaveAdmin : FormBase
    {
        private const char CaracterOculto = '\u25CF';

        private bool claveVisible;

        public FormClaveAdmin()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtClave.Focus();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClave.Text.Length == 0)
                {
                    lblError.Text = "Escriba la contraseña del administrador.";
                    txtClave.Focus();
                    return;
                }

                string error;
                if (!Autenticacion.VerificarClaveAdministrador(txtClave.Text, out error))
                {
                    txtClave.Clear();
                    claveVisible = false;
                    AplicarVisibilidad();
                    lblError.Text = error;
                    txtClave.Focus();
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ManejadorErrores.Mostrar(ex, "Error al verificar la contraseña del administrador");
            }
        }

        private void btnOjo_Click(object sender, EventArgs e)
        {
            claveVisible = !claveVisible;
            AplicarVisibilidad();

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

        private void AplicarVisibilidad()
        {
            txtClave.PasswordChar = claveVisible ? '\0' : CaracterOculto;
            btnOjo.AccessibleName = claveVisible ? "Ocultar contraseña" : "Mostrar contraseña";
            btnOjo.Invalidate();
        }

        private void btnOjo_Paint(object sender, PaintEventArgs e)
        {
            UiContable.DibujarOjo(e.Graphics, btnOjo.ClientSize, claveVisible);
        }
    }
}
