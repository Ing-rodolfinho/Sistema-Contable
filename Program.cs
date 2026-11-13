using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ManejadorErrores.Instalar();

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (var login = new FormInicioSesion())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        return;
                }

                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                ManejadorErrores.Mostrar(ex, "No se pudo iniciar el sistema contable");
            }
        }
    }
}
