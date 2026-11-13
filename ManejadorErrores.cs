using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Centraliza el manejo de excepciones del sistema: registra los errores en un
    /// archivo de log y muestra un mensaje amigable al usuario. También instala los
    /// controladores globales para que ninguna excepción cierre la aplicación sin
    /// dejar rastro.
    /// </summary>
    internal static class ManejadorErrores
    {
        private static readonly object candado = new object();

        /// <summary>
        /// Ruta del archivo donde se guardan los errores.
        /// </summary>
        public static string RutaLog
        {
            get
            {
                string carpeta;
                try
                {
                    carpeta = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "Sistema Contable");
                }
                catch
                {
                    carpeta = AppDomain.CurrentDomain.BaseDirectory;
                }

                return Path.Combine(carpeta, "errores.log");
            }
        }

        /// <summary>
        /// Instala los controladores globales de excepciones. Debe llamarse al inicio
        /// de Main, antes de crear cualquier ventana.
        /// </summary>
        public static void Instalar()
        {
            // Las excepciones de los eventos de WinForms se envían al controlador
            // en lugar de cerrar la aplicación de golpe.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += AppDomain_UnhandledException;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Mostrar(e == null ? null : e.Exception, "Error inesperado en la aplicación");
        }

        private static void AppDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Registrar(e == null ? null : e.ExceptionObject as Exception,
                "Error no controlado (AppDomain)");

            // No se muestra un cuadro de diálogo aquí: el proceso está terminando y
            // hacerlo puede dejar la aplicación bloqueada. El log ya quedó escrito.
        }

        /// <summary>
        /// Ejecuta una acción capturando cualquier excepción, registrándola y
        /// mostrando un mensaje al usuario.
        /// </summary>
        public static bool Ejecutar(Action accion, string contexto)
        {
            if (accion == null) return false;

            try
            {
                accion();
                return true;
            }
            catch (Exception ex)
            {
                Mostrar(ex, contexto);
                return false;
            }
        }

        /// <summary>
        /// Registra la excepción y muestra un mensaje amigable al usuario.
        /// </summary>
        public static void Mostrar(Exception ex, string contexto)
        {
            Registrar(ex, contexto);

            string detalle = ex == null ? "No se pudo completar la operación."
                : ex.Message;

            try
            {
                MessageBox.Show(
                    (string.IsNullOrWhiteSpace(contexto) ? "Ocurrió un error." : contexto)
                        + Environment.NewLine + Environment.NewLine + detalle
                        + Environment.NewLine + Environment.NewLine
                        + "El detalle quedó registrado en:" + Environment.NewLine + RutaLog,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch
            {
                // Si ni siquiera se puede mostrar el cuadro de diálogo, el error ya
                // quedó registrado y no se debe volver a lanzar.
            }
        }

        /// <summary>
        /// Escribe la excepción en el archivo de log. Nunca lanza excepciones.
        /// </summary>
        public static void Registrar(Exception ex, string contexto)
        {
            try
            {
                var texto = new StringBuilder();
                texto.AppendLine("================================================================");
                texto.AppendLine("Fecha: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                if (!string.IsNullOrWhiteSpace(contexto))
                    texto.AppendLine("Contexto: " + contexto);
                texto.AppendLine("Usuario de Windows: " + Environment.UserName);
                texto.AppendLine("Equipo: " + Environment.MachineName);

                if (ex == null)
                {
                    texto.AppendLine("Excepción: (sin detalle)");
                }
                else
                {
                    texto.AppendLine("Tipo: " + ex.GetType().FullName);
                    texto.AppendLine("Mensaje: " + ex.Message);
                    texto.AppendLine("Origen: " + ex.Source);
                    texto.AppendLine("Método: " + ex.TargetSite);
                    texto.AppendLine("Stack trace:");
                    texto.AppendLine(ex.ToString());
                }

                texto.AppendLine();

                string ruta = RutaLog;
                string carpeta = Path.GetDirectoryName(ruta);
                if (!string.IsNullOrEmpty(carpeta) && !Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                lock (candado)
                {
                    File.AppendAllText(ruta, texto.ToString(), Encoding.UTF8);
                }
            }
            catch
            {
                // El registro de errores no debe provocar un nuevo error.
            }
        }
    }
}
