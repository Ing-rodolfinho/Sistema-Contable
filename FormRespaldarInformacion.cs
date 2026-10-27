using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormRespaldarInformacion : FormBase
    {
        private readonly string carpetaRespaldos = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Sistema Contable", "Respaldos");

        private DataGridView dgvRespaldos;
        private Label lblResumen;
        private Label lblEstado;
        private Button btnCrear;
        private Button btnRestaurar;
        private Button btnAbrirCarpeta;

        public FormRespaldarInformacion()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            Text = "Respaldar Información";
            BackColor = UiContable.Fondo;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);

            TableLayoutPanel raiz = UiContable.CrearRaiz(this, "RESPALDAR INFORMACIÓN");

            FlowLayoutPanel acciones = UiContable.CrearBarra();
            btnCrear = UiContable.CrearBoton("Crear respaldo", btnCrear_Click);
            btnRestaurar = UiContable.CrearBoton("Restaurar seleccionado", btnRestaurar_Click);
            btnAbrirCarpeta = UiContable.CrearBoton("Abrir carpeta de respaldos", btnAbrirCarpeta_Click);
            acciones.Controls.Add(btnCrear);
            acciones.Controls.Add(btnRestaurar);
            acciones.Controls.Add(btnAbrirCarpeta);
            acciones.Controls.Add(UiContable.CrearBoton("Actualizar", btnActualizar_Click));
            raiz.Controls.Add(acciones, 0, 1);

            var contenido = new TableLayoutPanel();
            contenido.Dock = DockStyle.Fill;
            contenido.ColumnCount = 1;
            contenido.RowCount = 2;
            contenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contenido.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            contenido.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            lblResumen = new Label();
            lblResumen.AutoSize = false;
            lblResumen.Dock = DockStyle.Fill;
            lblResumen.Height = 74;
            lblResumen.Font = UiContable.Fuente(10F);
            lblResumen.ForeColor = UiContable.Texto;
            lblResumen.BackColor = Color.White;
            lblResumen.Padding = new Padding(14, 8, 14, 8);
            lblResumen.TextAlign = ContentAlignment.MiddleLeft;
            lblResumen.Margin = new Padding(0, 0, 0, 10);
            contenido.Controls.Add(lblResumen, 0, 0);

            dgvRespaldos = UiContable.CrearGrid();
            dgvRespaldos.Columns.AddRange(new DataGridViewColumn[]
            {
                UiContable.Columna("colFecha", "Fecha del respaldo", 130F, false),
                UiContable.Columna("colCarpeta", "Carpeta", 260F, false),
                UiContable.Columna("colCuentas", "Cuentas", 90F, false),
                UiContable.Columna("colOperaciones", "Operaciones", 100F, false),
                UiContable.Columna("colTamano", "Tamaño", 90F, true)
            });
            dgvRespaldos.CellDoubleClick += dgvRespaldos_CellDoubleClick;
            contenido.Controls.Add(UiContable.CrearTarjeta(dgvRespaldos), 0, 1);

            raiz.Controls.Add(contenido, 0, 2);

            lblEstado = UiContable.CrearEstado();
            raiz.Controls.Add(lblEstado, 0, 3);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Recargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Recargar();
        }

        private void Recargar()
        {
            ActualizarResumen();
            CargarRespaldos();
        }

        private void ActualizarResumen()
        {
            string rutaCuentas = DatosContables.RutaCuentas;
            string rutaOperaciones = DatosContables.RutaOperaciones;

            int totalCuentas = 0;
            int totalAsientos = 0;
            string errorCuentas;
            string errorOperaciones;

            totalCuentas = DatosContables.CargarCuentas(out errorCuentas).Count;
            totalAsientos = DatosContables.CargarAsientos(out errorOperaciones).Count;

            List<string> lineas = new List<string>
            {
                "Datos actuales",
                "Cuentas: " + DescribirArchivo(rutaCuentas) + "   |   " + totalCuentas + " cuentas",
                "Operaciones: " + DescribirArchivo(rutaOperaciones) + "   |   " + totalAsientos + " asientos",
                "Carpeta de respaldos: " + carpetaRespaldos
            };

            if (!string.IsNullOrEmpty(errorCuentas)) lineas.Add(errorCuentas);
            if (!string.IsNullOrEmpty(errorOperaciones)) lineas.Add(errorOperaciones);

            lblResumen.Text = string.Join(Environment.NewLine, lineas);
        }

        private static string DescribirArchivo(string ruta)
        {
            try
            {
                if (!File.Exists(ruta)) return "no encontrado";
                var info = new FileInfo(ruta);
                return info.Name + " (" + info.LastWriteTime.ToString("dd/MM/yyyy HH:mm") + ")";
            }
            catch
            {
                return "no disponible";
            }
        }

        private void CargarRespaldos()
        {
            dgvRespaldos.Rows.Clear();

            try
            {
                if (!Directory.Exists(carpetaRespaldos))
                {
                    Directory.CreateDirectory(carpetaRespaldos);
                }

                var carpetas = Directory.GetDirectories(carpetaRespaldos)
                    .OrderByDescending(c => c, StringComparer.OrdinalIgnoreCase)
                    .ToList();

                foreach (string carpeta in carpetas)
                {
                    string nombre = Path.GetFileName(carpeta);
                    string cuentas = Path.Combine(carpeta, "Cuentas.json");
                    string operaciones = Path.Combine(carpeta, "operaciones.json");

                    DateTime fecha = Directory.GetLastWriteTime(carpeta);
                    string detalleCuentas = File.Exists(cuentas)
                        ? new FileInfo(cuentas).Length / 1024.0 + " KB"
                        : "falta";
                    string detalleOperaciones = File.Exists(operaciones)
                        ? new FileInfo(operaciones).Length / 1024.0 + " KB"
                        : "falta";

                    decimal totalKb = 0m;
                    if (File.Exists(cuentas)) totalKb += (decimal)new FileInfo(cuentas).Length / 1024m;
                    if (File.Exists(operaciones)) totalKb += (decimal)new FileInfo(operaciones).Length / 1024m;

                    int fila = dgvRespaldos.Rows.Add(
                        fecha.ToString("dd/MM/yyyy HH:mm:ss"),
                        nombre,
                        detalleCuentas,
                        detalleOperaciones,
                        totalKb.ToString("N1") + " KB");

                    dgvRespaldos.Rows[fila].Tag = carpeta;

                    if (!File.Exists(cuentas) || !File.Exists(operaciones))
                        UiContable.EstilizarFila(dgvRespaldos.Rows[fila], true, Color.FromArgb(255, 235, 238));
                }

                lblEstado.ForeColor = UiContable.Acento;
                lblEstado.Text = carpetas.Count == 0
                    ? "Todavía no hay respaldos. Use «Crear respaldo» para generar el primero."
                    : "Respaldos disponibles: " + carpetas.Count + ". Seleccione uno para restaurarlo.";
            }
            catch (Exception ex)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "No se pudo leer la carpeta de respaldos: " + ex.Message;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaCuentas = DatosContables.RutaCuentas;
                string rutaOperaciones = DatosContables.RutaOperaciones;

                if (!File.Exists(rutaCuentas) && !File.Exists(rutaOperaciones))
                {
                    lblEstado.ForeColor = UiContable.Negativo;
                    lblEstado.Text = "No se encontraron los archivos de datos para respaldar.";
                    return;
                }

                string nombre = "respaldo_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string destino = Path.Combine(carpetaRespaldos, nombre);
                Directory.CreateDirectory(destino);

                int copiados = 0;
                if (File.Exists(rutaCuentas))
                {
                    DatosContables.CopiarArchivoSeguro(rutaCuentas, Path.Combine(destino, "Cuentas.json"));
                    copiados++;
                }

                if (File.Exists(rutaOperaciones))
                {
                    DatosContables.CopiarArchivoSeguro(rutaOperaciones, Path.Combine(destino, "operaciones.json"));
                    copiados++;
                }

                if (copiados == 0)
                {
                    Directory.Delete(destino, true);
                    lblEstado.ForeColor = UiContable.Negativo;
                    lblEstado.Text = "No se pudo copiar ningún archivo de datos.";
                    return;
                }

                CargarRespaldos();
                lblEstado.ForeColor = UiContable.Positivo;
                lblEstado.Text = "Respaldo creado en " + destino + " (" + copiados + " archivo(s)).";
            }
            catch (Exception ex)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "No se pudo crear el respaldo: " + ex.Message;
            }
        }

        private void dgvRespaldos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            RestaurarSeleccionado();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarSeleccionado();
        }

        private void RestaurarSeleccionado()
        {
            if (dgvRespaldos.SelectedRows.Count == 0)
            {
                lblEstado.ForeColor = UiContable.Acento;
                lblEstado.Text = "Seleccione un respaldo de la lista para restaurarlo.";
                return;
            }

            string carpeta = dgvRespaldos.SelectedRows[0].Tag as string;
            if (string.IsNullOrEmpty(carpeta) || !Directory.Exists(carpeta))
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "La carpeta del respaldo seleccionado ya no existe.";
                return;
            }

            string origenCuentas = Path.Combine(carpeta, "Cuentas.json");
            string origenOperaciones = Path.Combine(carpeta, "operaciones.json");

            if (!File.Exists(origenCuentas) && !File.Exists(origenOperaciones))
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "El respaldo seleccionado no contiene archivos de datos.";
                return;
            }

            if (!ValidarArchivo(origenCuentas) || !ValidarArchivo(origenOperaciones))
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "El respaldo contiene archivos con formato inválido. No se restauró nada.";
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "Se reemplazarán los datos actuales con el respaldo:" + Environment.NewLine + Environment.NewLine
                + Path.GetFileName(carpeta) + Environment.NewLine + Environment.NewLine
                + "¿Desea continuar?",
                "Restaurar respaldo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                string destinoCuentas = DatosContables.RutaCuentas;
                string destinoOperaciones = DatosContables.RutaOperaciones;

                if (File.Exists(origenCuentas))
                {
                    DatosContables.CopiarArchivoSeguro(origenCuentas, destinoCuentas);
                    CopiarCopiaProyecto(destinoCuentas, DatosContables.RutaCuentasProyecto);
                }

                if (File.Exists(origenOperaciones))
                {
                    DatosContables.CopiarArchivoSeguro(origenOperaciones, destinoOperaciones);
                    CopiarCopiaProyecto(destinoOperaciones, DatosContables.RutaOperacionesProyecto);
                }

                Recargar();
                lblEstado.ForeColor = UiContable.Positivo;
                lblEstado.Text = "Respaldo restaurado correctamente.";
            }
            catch (Exception ex)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "No se pudo restaurar el respaldo: " + ex.Message;
            }
        }

        private static void CopiarCopiaProyecto(string rutaOrigen, string rutaProyecto)
        {
            try
            {
                if (!string.Equals(rutaOrigen, rutaProyecto, StringComparison.OrdinalIgnoreCase)
                    && File.Exists(rutaProyecto))
                {
                    DatosContables.CopiarArchivoSeguro(rutaOrigen, rutaProyecto);
                }
            }
            catch
            {
                // La copia del proyecto es opcional; no debe impedir la restauración.
            }
        }

        private static bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta)) return true;

            try
            {
                JsonNode nodo = JsonNode.Parse(File.ReadAllText(ruta));
                return nodo is JsonObject;
            }
            catch
            {
                return false;
            }
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(carpetaRespaldos))
                    Directory.CreateDirectory(carpetaRespaldos);

                Process.Start("explorer.exe", "\"" + carpetaRespaldos + "\"");
            }
            catch (Exception ex)
            {
                lblEstado.ForeColor = UiContable.Negativo;
                lblEstado.Text = "No se pudo abrir la carpeta: " + ex.Message;
            }
        }
    }
}
