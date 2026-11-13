using System;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class FormBase : Form
    {
        private bool contenidoPreparado;

        public FormBase()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.UserPaint | 
                     ControlStyles.OptimizedDoubleBuffer | 
                     ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            UpdateStyles();
        }

        /// <summary>
        /// Indica si los datos y el diseño del formulario ya fueron preparados.
        /// </summary>
        protected bool ContenidoPreparado
        {
            get { return contenidoPreparado; }
        }

        /// <summary>
        /// Carga los datos y deja el diseño listo antes de que el formulario
        /// sea visible. Así el primer dibujo ya muestra el contenido completo.
        /// </summary>
        public void PrepararContenido()
        {
            if (contenidoPreparado) return;
            contenidoPreparado = true;

            SuspendLayout();
            try
            {
                HabilitarDobleBuffer(this);
                CrearHandles(this);
                OnPrepararContenido();
                RealizarDiseno(this);
            }
            finally
            {
                ResumeLayout(true);
                RealizarDiseno(this);
            }
        }

        /// <summary>
        /// Punto de carga previo a la visualización. Los formularios que
        /// cargan datos deben sobrescribir este método en lugar del evento Load.
        /// </summary>
        protected virtual void OnPrepararContenido()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                PrepararContenido();
            }
            catch (Exception ex)
            {
                ManejadorErrores.Mostrar(ex, "Error al preparar la pantalla");
            }

            base.OnLoad(e);
        }

        private static void HabilitarDobleBuffer(Control control)
        {
            if (control == null) return;

            if (control is DataGridView || control is TreeView || control is ListView)
            {
                try
                {
                    PropertyInfo propiedad = typeof(Control).GetProperty(
                        "DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
                    if (propiedad != null && propiedad.CanWrite)
                        propiedad.SetValue(control, true, null);
                }
                catch
                {
                }
            }

            foreach (Control hijo in control.Controls)
                HabilitarDobleBuffer(hijo);
        }

        /// <summary>
        /// Crea los controles nativos de todo el árbol. Los formularios que se
        /// preparan ocultos necesitan sus handles para que el diseño definitivo
        /// se calcule antes de mostrarlos.
        /// </summary>
        private static void CrearHandles(Control control)
        {
            if (control == null) return;

            IntPtr handle = control.Handle;

            foreach (Control hijo in control.Controls)
                CrearHandles(hijo);
        }

        /// <summary>
        /// Ejecuta el diseño de todos los contenedores, incluidos los que están
        /// ocultos, para que al mostrarse no cambie ninguna posición.
        /// </summary>
        private static void RealizarDiseno(Control control)
        {
            if (control == null) return;

            control.PerformLayout();

            foreach (Control hijo in control.Controls)
                RealizarDiseno(hijo);
        }
    }
}
