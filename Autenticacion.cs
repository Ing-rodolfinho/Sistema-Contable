using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WindowsFormsApp1
{
    public sealed class UsuarioSesion
    {
        public string Usuario { get; set; }
        public string Nombre { get; set; }
    }

    internal static class Autenticacion
    {
        /// <summary>
        /// Usuario que administra el sistema y autoriza la creación de usuarios.
        /// </summary>
        public const string UsuarioAdministrador = "admin";

        /// <summary>
        /// Longitud mínima aceptada para las contraseñas nuevas.
        /// </summary>
        public const int LongitudMinimaClave = 4;

        public static readonly string RutaUsuariosPrincipal =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.json");

        public static readonly string RutaUsuariosProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "usuarios.json"));

        public static string RutaUsuarios
        {
            get { return DatosContables.ResolverRuta(RutaUsuariosPrincipal, RutaUsuariosProyecto); }
        }

        /// <summary>
        /// Devuelve el hash SHA-256 (hexadecimal) de una contraseña.
        /// </summary>
        public static string HashClave(string clave)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(clave ?? string.Empty));
                var texto = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes)
                    texto.Append(b.ToString("x2"));
                return texto.ToString();
            }
        }

        /// <summary>
        /// Valida el usuario y la contraseña contra usuarios.json.
        /// </summary>
        public static bool IniciarSesion(string usuario, string clave, out UsuarioSesion sesion, out string error)
        {
            sesion = null;
            error = string.Empty;

            usuario = (usuario ?? string.Empty).Trim();
            clave = clave ?? string.Empty;

            if (usuario.Length == 0 || clave.Length == 0)
            {
                error = "Escriba el nombre de usuario y la contraseña.";
                return false;
            }

            string ruta = RutaUsuarios;
            if (!File.Exists(ruta))
            {
                error = "No se encontró el archivo usuarios.json.";
                return false;
            }

            try
            {
                using (JsonDocument documento = JsonDocument.Parse(File.ReadAllText(ruta, Encoding.UTF8)))
                {
                    JsonElement raiz = documento.RootElement;
                    JsonElement lista;

                    if (raiz.ValueKind != JsonValueKind.Object ||
                        !raiz.TryGetProperty("usuarios", out lista) ||
                        lista.ValueKind != JsonValueKind.Array)
                    {
                        error = "El archivo usuarios.json no contiene la lista de usuarios.";
                        return false;
                    }

                    string hash = HashClave(clave);

                    foreach (JsonElement item in lista.EnumerateArray())
                    {
                        if (item.ValueKind != JsonValueKind.Object) continue;

                        string nombreUsuario = LeerTexto(item, "usuario");
                        if (!string.Equals(nombreUsuario, usuario, StringComparison.OrdinalIgnoreCase))
                            continue;

                        bool activo = LeerBooleano(item, "activo", true);
                        string hashGuardado = LeerTexto(item, "clave_hash");

                        if (activo && hashGuardado.Length > 0 &&
                            string.Equals(hashGuardado, hash, StringComparison.OrdinalIgnoreCase))
                        {
                            sesion = new UsuarioSesion
                            {
                                Usuario = nombreUsuario,
                                Nombre = LeerTexto(item, "nombre")
                            };

                            if (string.IsNullOrWhiteSpace(sesion.Nombre))
                                sesion.Nombre = nombreUsuario;

                            return true;
                        }

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                error = "Error al leer usuarios.json: " + ex.Message;
                return false;
            }

            error = "Usuario o contraseña incorrectos.";
            return false;
        }

        /// <summary>
        /// Verifica únicamente la contraseña de la cuenta administradora.
        /// </summary>
        public static bool VerificarClaveAdministrador(string clave, out string error)
        {
            UsuarioSesion sesion;
            if (IniciarSesion(UsuarioAdministrador, clave, out sesion, out error))
                return true;

            if (string.Equals(error, "Usuario o contraseña incorrectos.", StringComparison.Ordinal))
                error = "La contraseña del administrador no es correcta.";

            return false;
        }

        /// <summary>
        /// Agrega un nuevo usuario a usuarios.json con la contraseña cifrada en SHA-256.
        /// </summary>
        public static bool CrearUsuario(string usuario, string nombre, string clave, out string error)
        {
            error = string.Empty;
            usuario = (usuario ?? string.Empty).Trim();
            nombre = (nombre ?? string.Empty).Trim();
            clave = clave ?? string.Empty;

            if (usuario.Length == 0)
            {
                error = "Escriba el nombre de usuario.";
                return false;
            }
            if (!EsUsuarioValido(usuario))
            {
                error = "El usuario solo puede contener letras, números, punto, guion y guion bajo.";
                return false;
            }
            if (nombre.Length == 0)
            {
                error = "Escriba el nombre completo del usuario.";
                return false;
            }
            if (clave.Length < LongitudMinimaClave)
            {
                error = "La contraseña debe tener al menos " + LongitudMinimaClave + " caracteres.";
                return false;
            }

            try
            {
                string errorLectura;
                JsonObject raiz = LeerUsuarios(out errorLectura);
                if (raiz == null)
                {
                    error = errorLectura;
                    return false;
                }

                var lista = (JsonArray)raiz["usuarios"];
                foreach (JsonNode nodo in lista)
                {
                    var item = nodo as JsonObject;
                    if (item == null) continue;

                    if (string.Equals(LeerTexto(item, "usuario"), usuario, StringComparison.OrdinalIgnoreCase))
                    {
                        error = "Ya existe un usuario con el nombre \"" + usuario + "\".";
                        return false;
                    }
                }

                lista.Add(new JsonObject
                {
                    ["usuario"] = usuario,
                    ["nombre"] = nombre,
                    ["clave_hash"] = HashClave(clave),
                    ["activo"] = true
                });

                GuardarUsuarios(raiz);
                return true;
            }
            catch (Exception ex)
            {
                error = "Error al guardar usuarios.json: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Cambia la contraseña de un usuario verificando primero la contraseña actual.
        /// </summary>
        public static bool CambiarClave(string usuario, string claveActual, string claveNueva, out string error)
        {
            error = string.Empty;
            usuario = (usuario ?? string.Empty).Trim();
            claveActual = claveActual ?? string.Empty;
            claveNueva = claveNueva ?? string.Empty;

            if (usuario.Length == 0)
            {
                error = "Escriba el nombre de usuario.";
                return false;
            }
            if (claveActual.Length == 0)
            {
                error = "Escriba la contraseña actual.";
                return false;
            }
            if (claveNueva.Length < LongitudMinimaClave)
            {
                error = "La nueva contraseña debe tener al menos " + LongitudMinimaClave + " caracteres.";
                return false;
            }
            if (string.Equals(claveActual, claveNueva, StringComparison.Ordinal))
            {
                error = "La nueva contraseña debe ser diferente de la actual.";
                return false;
            }

            try
            {
                string errorLectura;
                JsonObject raiz = LeerUsuarios(out errorLectura);
                if (raiz == null)
                {
                    error = errorLectura;
                    return false;
                }

                var lista = (JsonArray)raiz["usuarios"];
                string hashActual = HashClave(claveActual);

                foreach (JsonNode nodo in lista)
                {
                    var item = nodo as JsonObject;
                    if (item == null) continue;

                    if (!string.Equals(LeerTexto(item, "usuario"), usuario, StringComparison.OrdinalIgnoreCase))
                        continue;

                    if (!LeerBooleano(item, "activo", true))
                    {
                        error = "El usuario está inactivo.";
                        return false;
                    }

                    if (!string.Equals(LeerTexto(item, "clave_hash"), hashActual,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        error = "La contraseña actual no es correcta.";
                        return false;
                    }

                    item["clave_hash"] = HashClave(claveNueva);
                    GuardarUsuarios(raiz);
                    return true;
                }

                error = "No existe un usuario con el nombre \"" + usuario + "\".";
                return false;
            }
            catch (Exception ex)
            {
                error = "Error al guardar usuarios.json: " + ex.Message;
                return false;
            }
        }

        private static bool EsUsuarioValido(string usuario)
        {
            foreach (char caracter in usuario)
            {
                if (!char.IsLetterOrDigit(caracter) && caracter != '.' && caracter != '_' && caracter != '-')
                    return false;
            }
            return usuario.Length > 0;
        }

        private static JsonObject LeerUsuarios(out string error)
        {
            error = string.Empty;
            string ruta = RutaUsuarios;

            if (!File.Exists(ruta))
            {
                error = "No se encontró el archivo usuarios.json.";
                return null;
            }

            JsonObject raiz = JsonNode.Parse(File.ReadAllText(ruta, Encoding.UTF8)) as JsonObject;
            if (raiz == null || !(raiz["usuarios"] is JsonArray))
            {
                error = "El archivo usuarios.json no contiene la lista de usuarios.";
                return null;
            }

            return raiz;
        }

        private static void GuardarUsuarios(JsonObject raiz)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string contenido = raiz.ToJsonString(opciones);
            string ruta = RutaUsuarios;

            DatosContables.GuardarJsonSeguro(ruta, contenido);

            try
            {
                if (!string.Equals(ruta, RutaUsuariosProyecto, StringComparison.OrdinalIgnoreCase)
                    && File.Exists(RutaUsuariosProyecto))
                {
                    DatosContables.GuardarJsonSeguro(RutaUsuariosProyecto, contenido);
                }
            }
            catch
            {
            }
        }

        private static string LeerTexto(JsonElement objeto, string clave)
        {
            JsonElement valor;
            if (!objeto.TryGetProperty(clave, out valor)) return string.Empty;
            return valor.ValueKind == JsonValueKind.String ? (valor.GetString() ?? string.Empty) : string.Empty;
        }

        private static bool LeerBooleano(JsonElement objeto, string clave, bool predeterminado)
        {
            JsonElement valor;
            if (!objeto.TryGetProperty(clave, out valor)) return predeterminado;
            if (valor.ValueKind == JsonValueKind.True) return true;
            if (valor.ValueKind == JsonValueKind.False) return false;
            return predeterminado;
        }

        private static string LeerTexto(JsonObject objeto, string clave)
        {
            if (objeto == null) return string.Empty;

            var valor = objeto[clave] as JsonValue;
            if (valor == null) return string.Empty;

            string texto;
            return valor.TryGetValue(out texto) ? (texto ?? string.Empty) : string.Empty;
        }

        private static bool LeerBooleano(JsonObject objeto, string clave, bool predeterminado)
        {
            if (objeto == null) return predeterminado;

            var valor = objeto[clave] as JsonValue;
            if (valor == null) return predeterminado;

            bool resultado;
            return valor.TryGetValue(out resultado) ? resultado : predeterminado;
        }
    }
}
