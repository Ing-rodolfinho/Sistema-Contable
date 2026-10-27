using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : FormBase
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_SETREDRAW = 0x0B;

        public Form1()
        {
            InitializeComponent();
            panelContenedor.SizeChanged += panelContenedor_SizeChanged;
        }

        private void panelContenedor_SizeChanged(object sender, EventArgs e)
        {
            AjustarFormularioActivo();
        }

        private void AjustarFormularioActivo()
        {
            if (formularioActivo == null || formularioActivo.IsDisposed) return;
            if (panelContenedor == null || panelContenedor.IsDisposed) return;

            // Los formularios hijos (TopLevel = false) no obedecen Dock en WinForms;
            // por eso se ajustan explícitamente al área disponible.
            Rectangle area = new Rectangle(Point.Empty, panelContenedor.ClientSize);
            if (formularioActivo.Bounds != area)
            {
                formularioActivo.Bounds = area;
                formularioActivo.PerformLayout();
            }
        }

        private void SuspendTree(Control control)
        {
            if (control == null) return;
            control.SuspendLayout();
            foreach (Control child in control.Controls)
                SuspendTree(child);
        }

        private void ResumeTree(Control control)
        {
            if (control == null) return;
            foreach (Control child in control.Controls)
                ResumeTree(child);
            control.ResumeLayout(true);
        }

        private Button botonActivo;
        private Form formularioActivo;

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Button1.Text = DateTime.Now.ToString("dd/MM/yyyy");

            Rectangle area = Screen.FromControl(this).WorkingArea;
            int ancho = Math.Min(Width, area.Width - 20);
            int alto = Math.Min(Height, area.Height - 20);
            Size = new Size(
                Math.Max(MinimumSize.Width, ancho),
                Math.Max(MinimumSize.Height, alto));

            if (AbrirFormularioHijo(new FormInicio(), false))
                EstablecerBotonActivo(button6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CerrarFormularioActivo()
        {
            if (formularioActivo == null || formularioActivo.IsDisposed) return true;

            formularioActivo.Close();
            return formularioActivo.IsDisposed;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CerrarFormularioActivo())
            {
                e.Cancel = true;
            }
        }

        private bool AbrirFormularioHijo(Form formularioHijo)
        {
            return AbrirFormularioHijo(formularioHijo, true);
        }

        private bool AbrirFormularioHijo(Form formularioHijo, bool mostrarCarga)
        {
            if (formularioHijo == null) return false;

            if (!CambiarFormularioHijo(formularioHijo))
            {
                formularioHijo.Dispose();
                return false;
            }

            return true;
        }

        private bool CambiarFormularioHijo(Form formularioHijo)
        {
            if (panelContenedor == null || panelContenedor.IsDisposed) return false;

            // Primero cerramos el formulario activo: si el usuario cancela
            // (por cambios sin guardar) no se cambia de pantalla.
            if (!CerrarFormularioActivo()) return false;

            SendMessage(Handle, WM_SETREDRAW, 0, 0);
            SendMessage(panelContenedor.Handle, WM_SETREDRAW, 0, 0);

            SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendTree(panelContenedor);
            SuspendTree(this);

            formularioHijo.SuspendLayout();
            SuspendTree(formularioHijo);

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            formularioHijo.Visible = false;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formularioHijo);
            AjustarFormularioActivo();

            formularioHijo.Visible = true;

            ResumeTree(formularioHijo);
            formularioHijo.ResumeLayout(true);

            ResumeTree(panelContenedor);
            panelContenedor.ResumeLayout(true);

            ResumeTree(this);
            ResumeLayout(true);

            SendMessage(panelContenedor.Handle, WM_SETREDRAW, 1, 0);
            SendMessage(Handle, WM_SETREDRAW, 1, 0);

            panelContenedor.Invalidate(true);
            Invalidate(true);
            panelContenedor.Update();
            Update();

            return true;
        }

        private void EstablecerBotonActivo(Button boton)
        {
            if (boton == null) return;

            if (botonActivo != null)
            {
                botonActivo.BackColor = Color.LightPink;
                botonActivo.ForeColor = Color.SaddleBrown;
            }

            botonActivo = boton;
            botonActivo.BackColor = Color.Tan;
            botonActivo.ForeColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormInicio())) EstablecerBotonActivo(button6);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormAdministrarCuentas())) EstablecerBotonActivo(button1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormRegistrarOperaciones())) EstablecerBotonActivo(button5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormConsultarCuentasT())) EstablecerBotonActivo(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormGenerarLibroDiario())) EstablecerBotonActivo(button3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormGenerarLibroMayor())) EstablecerBotonActivo(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormGenerarBalanzaDeComprobación())) EstablecerBotonActivo(button7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormGenerarEstadosDeResultados())) EstablecerBotonActivo(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormGenerarBalanceGeneral())) EstablecerBotonActivo(button10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormConsultarMovimientos())) EstablecerBotonActivo(button4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioHijo(new FormRespaldarInformacion())) EstablecerBotonActivo(button11);
        }
    }
}