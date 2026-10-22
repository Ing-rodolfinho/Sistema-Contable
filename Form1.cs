using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button botonActivo;
        private Form formularioActivo;

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Button1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            EstablecerBotonActivo(button6);
            AbrirFormularioHijo(new FormInicio(), false);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formularioActivo == null || formularioActivo.IsDisposed) return;

            formularioActivo.Close();

            if (!formularioActivo.IsDisposed)
            {
                e.Cancel = true;
            }
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            AbrirFormularioHijo(formularioHijo, true);
        }

        private void AbrirFormularioHijo(Form formularioHijo, bool mostrarCarga)
        {
            CambiarFormularioHijo(formularioHijo);
        }

        private void CambiarFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null && !formularioActivo.IsDisposed)
            {
                formularioActivo.Close();

                if (!formularioActivo.IsDisposed)
                {
                    formularioHijo.Dispose();
                    return;
                }
            }

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
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
            EstablecerBotonActivo(button6);
            AbrirFormularioHijo(new FormInicio());
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
            EstablecerBotonActivo(button1);
            AbrirFormularioHijo(new FormAdministrarCuentas());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button5);
            AbrirFormularioHijo(new FormRegistrarOperaciones());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button2);
            AbrirFormularioHijo(new FormConsultarCuentasT());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button3);
            AbrirFormularioHijo(new FormGenerarLibroDiario());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button8);
            AbrirFormularioHijo(new FormGenerarLibroMayor());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button7);
            AbrirFormularioHijo(new FormGenerarBalanzaDeComprobación());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button9);
            AbrirFormularioHijo(new FormGenerarEstadosDeResultados());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button10);
            AbrirFormularioHijo(new FormGenerarBalanceGeneral());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button4);
            AbrirFormularioHijo(new FormConsultarMovimientos());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EstablecerBotonActivo(button11);
            AbrirFormularioHijo(new FormRespaldarInformacion());
        }
    }
}
