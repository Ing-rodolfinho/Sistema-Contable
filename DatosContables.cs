using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WindowsFormsApp1
{
    internal sealed class CuentaContable
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Naturaleza { get; set; }
        public string Estado { get; set; }
        public string TipoClave { get; set; }
        public string TipoNombre { get; set; }
        public string GrupoClave { get; set; }
        public string GrupoNombre { get; set; }

        public bool EsDeudora
        {
            get { return Naturaleza != DatosContables.NaturalezaCredito; }
        }

        public bool EsActiva
        {
            get { return Estado != DatosContables.EstadoInactivo; }
        }

        public bool EsActivo
        {
            get { return (TipoClave ?? string.Empty).IndexOf("activo", StringComparison.OrdinalIgnoreCase) >= 0; }
        }

        public bool EsPasivo
        {
            get { return (TipoClave ?? string.Empty).IndexOf("pasivo", StringComparison.OrdinalIgnoreCase) >= 0; }
        }

        public bool EsPatrimonio
        {
            get { return (TipoClave ?? string.Empty).IndexOf("patrimonio", StringComparison.OrdinalIgnoreCase) >= 0; }
        }

        public bool EsIngreso
        {
            get
            {
                string grupo = (GrupoClave ?? string.Empty).ToLowerInvariant();
                return grupo.IndexOf("ingreso", StringComparison.Ordinal) >= 0;
            }
        }

        public bool EsGasto
        {
            get
            {
                string grupo = (GrupoClave ?? string.Empty).ToLowerInvariant();
                return grupo.IndexOf("gasto", StringComparison.Ordinal) >= 0
                    || grupo.IndexOf("egreso", StringComparison.Ordinal) >= 0
                    || grupo.IndexOf("costo", StringComparison.Ordinal) >= 0;
            }
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Codigo)) return Nombre;

            string etiqueta = EsDeudora ? "Débito" : "Crédito";
            return Codigo + " - " + Nombre + " (" + etiqueta + ")";
        }
    }

    internal sealed class PartidaContable
    {
        public string Cuenta { get; set; }
        public string NombreCuenta { get; set; }
        public string Naturaleza { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
    }

    internal sealed class AsientoContable
    {
        public int Numero { get; set; }
        public DateTime? Fecha { get; set; }
        public string FechaTexto { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public decimal TotalDebe { get; set; }
        public decimal TotalHaber { get; set; }
        public List<PartidaContable> Partidas { get; set; }

        public AsientoContable()
        {
            Partidas = new List<PartidaContable>();
        }

        public bool Cuadra
        {
            get { return Math.Abs(TotalDebe - TotalHaber) < 0.005m; }
        }
    }

    internal static class DatosContables
    {
        public const string NaturalezaDebito = "debito";
        public const string NaturalezaCredito = "credito";
        public const string EstadoActivo = "activo";
        public const string EstadoInactivo = "inactivo";

        public static readonly string RutaCuentasPrincipal =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cuentas.json");

        public static readonly string RutaCuentasProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Cuentas.json"));

        public static readonly string RutaOperacionesPrincipal =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "operaciones.json");

        public static readonly string RutaOperacionesProyecto = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "operaciones.json"));

        public static string RutaCuentas
        {
            get { return ResolverRuta(RutaCuentasPrincipal, RutaCuentasProyecto); }
        }

        public static string RutaOperaciones
        {
            get { return ResolverRuta(RutaOperacionesPrincipal, RutaOperacionesProyecto); }
        }

        public static string ResolverRuta(string rutaPrincipal, string rutaProyecto)
        {
            if (File.Exists(rutaPrincipal)) return rutaPrincipal;
            if (File.Exists(rutaProyecto)) return rutaProyecto;
            return rutaPrincipal;
        }

        public static string NombreBonito(string clave)
        {
            if (string.IsNullOrWhiteSpace(clave)) return clave ?? string.Empty;

            string[] partes = clave.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < partes.Length; i++)
            {
                string parte = partes[i];
                if (parte.Length == 0) continue;
                partes[i] = char.ToUpperInvariant(parte[0]) + parte.Substring(1).ToLowerInvariant();
            }
            return string.Join(" ", partes);
        }

        public static string EtiquetaNaturaleza(string naturaleza)
        {
            return naturaleza == NaturalezaCredito ? "Crédito" : "Débito";
        }

        public static string EtiquetaEstado(string estado)
        {
            return estado == EstadoInactivo ? "Inactiva" : "Activa";
        }

        public static string LeerTexto(JsonObject objeto, string clave)
        {
            if (objeto == null || !(objeto[clave] is JsonValue valor)) return string.Empty;
            string texto;
            return valor.TryGetValue(out texto) ? (texto ?? string.Empty) : string.Empty;
        }

        public static decimal LeerDecimal(JsonObject objeto, string clave)
        {
            if (objeto == null || !(objeto[clave] is JsonValue valor)) return 0m;

            decimal numero;
            if (valor.TryGetValue(out numero)) return numero;

            string texto;
            if (valor.TryGetValue(out texto)
                && decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out numero))
                return numero;

            return 0m;
        }

        public static int LeerEntero(JsonObject objeto, string clave)
        {
            if (objeto == null || !(objeto[clave] is JsonValue valor)) return 0;

            int numero;
            if (valor.TryGetValue(out numero)) return numero;

            decimal decimalNumero;
            if (valor.TryGetValue(out decimalNumero)) return (int)decimalNumero;

            string texto;
            if (valor.TryGetValue(out texto)
                && int.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out numero))
                return numero;

            return 0;
        }

        public static bool TryParseFecha(string texto, out DateTime fecha)
        {
            fecha = DateTime.MinValue;
            if (string.IsNullOrWhiteSpace(texto)) return false;

            if (DateTime.TryParseExact(texto.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out fecha))
                return true;

            if (DateTime.TryParse(texto, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
                return true;

            return DateTime.TryParse(texto, CultureInfo.CurrentCulture, DateTimeStyles.None, out fecha);
        }

        public static string FormatearFecha(DateTime? fecha)
        {
            return fecha.HasValue ? fecha.Value.ToString("dd/MM/yyyy") : string.Empty;
        }

        public static string FormatearMonto(decimal valor)
        {
            return valor.ToString("N2", CultureInfo.CurrentCulture);
        }

        public static string MontoCelda(decimal valor)
        {
            return valor == 0m ? string.Empty : valor.ToString("N2", CultureInfo.CurrentCulture);
        }

        public static List<CuentaContable> CargarCuentas(out string error)
        {
            error = null;
            var lista = new List<CuentaContable>();

            try
            {
                string ruta = RutaCuentas;
                if (!File.Exists(ruta))
                {
                    error = "No se encontró el archivo Cuentas.json.";
                    return lista;
                }

                JsonObject raiz = JsonNode.Parse(File.ReadAllText(ruta)) as JsonObject;
                JsonObject catalogo = raiz == null ? null : raiz["catalogo_cuentas"] as JsonObject;

                if (catalogo == null)
                {
                    error = "El archivo Cuentas.json no contiene el catálogo de cuentas.";
                    return lista;
                }

                foreach (KeyValuePair<string, JsonNode> tipo in catalogo)
                {
                    JsonObject grupos = tipo.Value as JsonObject;
                    if (grupos == null) continue;

                    foreach (KeyValuePair<string, JsonNode> grupo in grupos)
                    {
                        JsonArray cuentas = grupo.Value as JsonArray;
                        if (cuentas == null) continue;

                        foreach (JsonNode nodo in cuentas)
                        {
                            JsonObject obj = nodo as JsonObject;
                            if (obj == null) continue;

                            string codigo = LeerTexto(obj, "codigo").Trim();
                            if (codigo.Length == 0) continue;

                            string naturaleza = LeerTexto(obj, "naturaleza").Trim().ToLowerInvariant();
                            if (naturaleza != NaturalezaCredito) naturaleza = NaturalezaDebito;

                            string estado = LeerTexto(obj, "estado").Trim().ToLowerInvariant();
                            if (estado != EstadoInactivo) estado = EstadoActivo;

                            lista.Add(new CuentaContable
                            {
                                Codigo = codigo,
                                Nombre = LeerTexto(obj, "nombre").Trim(),
                                Naturaleza = naturaleza,
                                Estado = estado,
                                TipoClave = tipo.Key,
                                TipoNombre = NombreBonito(tipo.Key),
                                GrupoClave = grupo.Key,
                                GrupoNombre = NombreBonito(grupo.Key)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = "Error al leer Cuentas.json: " + ex.Message;
            }

            return lista;
        }

        public static List<AsientoContable> CargarAsientos(out string error)
        {
            error = null;
            var lista = new List<AsientoContable>();

            try
            {
                string ruta = RutaOperaciones;
                if (!File.Exists(ruta))
                {
                    error = "No se encontró el archivo operaciones.json.";
                    return lista;
                }

                JsonObject raiz = JsonNode.Parse(File.ReadAllText(ruta)) as JsonObject;
                JsonArray asientos = raiz == null ? null : raiz["asientos"] as JsonArray;

                if (asientos == null)
                {
                    error = "El archivo operaciones.json no contiene la lista de asientos.";
                    return lista;
                }

                foreach (JsonNode nodo in asientos)
                {
                    JsonObject obj = nodo as JsonObject;
                    if (obj == null) continue;

                    var asiento = new AsientoContable
                    {
                        Numero = LeerEntero(obj, "numero_asiento"),
                        FechaTexto = LeerTexto(obj, "fecha"),
                        Referencia = LeerTexto(obj, "referencia"),
                        Descripcion = LeerTexto(obj, "descripcion")
                    };

                    DateTime fecha;
                    asiento.Fecha = TryParseFecha(asiento.FechaTexto, out fecha) ? (DateTime?)fecha.Date : null;

                    if (obj["partidas"] is JsonArray partidas)
                    {
                        foreach (JsonNode partidaNodo in partidas)
                        {
                            JsonObject partidaObj = partidaNodo as JsonObject;
                            if (partidaObj == null) continue;

                            var partida = new PartidaContable
                            {
                                Cuenta = LeerTexto(partidaObj, "cuenta").Trim(),
                                NombreCuenta = LeerTexto(partidaObj, "nombre_cuenta").Trim(),
                                Naturaleza = LeerTexto(partidaObj, "naturaleza").Trim().ToLowerInvariant(),
                                Debe = LeerDecimal(partidaObj, "debe"),
                                Haber = LeerDecimal(partidaObj, "haber")
                            };

                            asiento.Partidas.Add(partida);
                            asiento.TotalDebe += partida.Debe;
                            asiento.TotalHaber += partida.Haber;
                        }
                    }

                    lista.Add(asiento);
                }
            }
            catch (Exception ex)
            {
                error = "Error al leer operaciones.json: " + ex.Message;
            }

            return lista;
        }

        public static Dictionary<string, CuentaContable> IndexarCuentas(IEnumerable<CuentaContable> cuentas)
        {
            var mapa = new Dictionary<string, CuentaContable>(StringComparer.OrdinalIgnoreCase);
            if (cuentas == null) return mapa;

            foreach (CuentaContable cuenta in cuentas)
            {
                if (cuenta == null || string.IsNullOrEmpty(cuenta.Codigo)) continue;
                mapa[cuenta.Codigo] = cuenta;
            }
            return mapa;
        }

        public static decimal EfectoEnNaturaleza(CuentaContable cuenta, decimal debe, decimal haber)
        {
            if (cuenta == null) return debe - haber;
            return cuenta.EsDeudora ? debe - haber : haber - debe;
        }

        public static decimal EfectoEnRango(CuentaContable cuenta, IEnumerable<AsientoContable> asientos,
            DateTime desde, DateTime hasta)
        {
            if (cuenta == null || asientos == null) return 0m;

            DateTime fechaDesde = desde.Date;
            DateTime fechaHasta = hasta.Date;
            decimal total = 0m;

            foreach (AsientoContable asiento in asientos)
            {
                if (!asiento.Fecha.HasValue) continue;
                if (asiento.Fecha.Value.Date < fechaDesde || asiento.Fecha.Value.Date > fechaHasta) continue;

                foreach (PartidaContable partida in asiento.Partidas)
                {
                    if (!string.Equals(partida.Cuenta, cuenta.Codigo, StringComparison.OrdinalIgnoreCase)) continue;
                    total += EfectoEnNaturaleza(cuenta, partida.Debe, partida.Haber);
                }
            }

            return total;
        }

        public static decimal SaldoEnFecha(CuentaContable cuenta, IEnumerable<AsientoContable> asientos, DateTime fecha)
        {
            if (cuenta == null) return 0m;

            // El saldo se calcula únicamente con los asientos registrados hasta la fecha;
            // Cuentas.json ya no almacena saldos iniciales.
            DateTime limite = fecha.Date;
            decimal total = 0m;

            if (asientos != null)
            {
                foreach (AsientoContable asiento in asientos)
                {
                    if (!asiento.Fecha.HasValue) continue;
                    if (asiento.Fecha.Value.Date > limite) continue;

                    foreach (PartidaContable partida in asiento.Partidas)
                    {
                        if (!string.Equals(partida.Cuenta, cuenta.Codigo, StringComparison.OrdinalIgnoreCase)) continue;
                        total += EfectoEnNaturaleza(cuenta, partida.Debe, partida.Haber);
                    }
                }
            }

            return total;
        }

        public static decimal SaldoDeudor(decimal saldoEnNaturaleza, CuentaContable cuenta)
        {
            if (cuenta == null) return saldoEnNaturaleza;
            return cuenta.EsDeudora ? saldoEnNaturaleza : -saldoEnNaturaleza;
        }

        public static decimal CalcularResultadoAcumulado(IEnumerable<AsientoContable> asientos,
            IDictionary<string, CuentaContable> cuentas, DateTime hasta)
        {
            if (asientos == null || cuentas == null) return 0m;

            DateTime limite = hasta.Date;
            decimal ingresos = 0m;
            decimal gastos = 0m;

            foreach (AsientoContable asiento in asientos)
            {
                if (!asiento.Fecha.HasValue || asiento.Fecha.Value.Date > limite) continue;

                foreach (PartidaContable partida in asiento.Partidas)
                {
                    CuentaContable cuenta;
                    if (!cuentas.TryGetValue(partida.Cuenta, out cuenta)) continue;

                    decimal efecto = EfectoEnNaturaleza(cuenta, partida.Debe, partida.Haber);
                    if (cuenta.EsIngreso) ingresos += efecto;
                    else if (cuenta.EsGasto) gastos += efecto;
                }
            }

            return ingresos - gastos;
        }

        public static IEnumerable<AsientoContable> OrdenarPorFecha(IEnumerable<AsientoContable> asientos)
        {
            var lista = new List<AsientoContable>();
            if (asientos != null) lista.AddRange(asientos);

            lista.Sort(delegate(AsientoContable a, AsientoContable b)
            {
                int comparacion = Nullable.Compare(a.Fecha, b.Fecha);
                if (comparacion != 0) return comparacion;
                return a.Numero.CompareTo(b.Numero);
            });

            return lista;
        }

        public static void GuardarJsonSeguro(string ruta, string contenido)
        {
            string directorio = Path.GetDirectoryName(ruta);
            if (!string.IsNullOrEmpty(directorio) && !Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            string temporal = ruta + ".tmp";
            File.WriteAllText(temporal, contenido, new UTF8Encoding(false));

            if (File.Exists(ruta))
            {
                try
                {
                    File.Replace(temporal, ruta, null, true);
                }
                catch
                {
                    File.Copy(temporal, ruta, true);
                    File.Delete(temporal);
                }
            }
            else
            {
                File.Move(temporal, ruta);
            }
        }

        public static void CopiarArchivoSeguro(string origen, string destino)
        {
            string directorio = Path.GetDirectoryName(destino);
            if (!string.IsNullOrEmpty(directorio) && !Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            string temporal = destino + ".tmp";
            File.Copy(origen, temporal, true);

            if (File.Exists(destino))
            {
                try
                {
                    File.Replace(temporal, destino, null, true);
                }
                catch
                {
                    File.Copy(temporal, destino, true);
                    File.Delete(temporal);
                }
            }
            else
            {
                File.Move(temporal, destino);
            }
        }

        public static void GuardarCopiaEnProyecto(string contenido, string rutaProyecto)
        {
            try
            {
                if (!File.Exists(rutaProyecto)) return;
                GuardarJsonSeguro(rutaProyecto, contenido);
            }
            catch
            {
            }
        }

        public static string SerializarJson(JsonNode nodo)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            return nodo.ToJsonString(opciones);
        }
    }
}
