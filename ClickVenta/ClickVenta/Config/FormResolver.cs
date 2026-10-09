using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClickVenta.Config
{
    public static class FormResolver
    {
        /// <summary>
        /// Devuelve el Type de un formulario a partir de:
        ///  - Nombre completo: "MiApp.Forms.frmUsuarios"
        ///  - Nombre simple:   "frmUsuarios"
        ///  - Case-insensitive: "FrmUsuarios" / "frmusuarios"
        /// </summary>
        public static Type? ResolverFormType(string nombreForm)
        {
            if (string.IsNullOrWhiteSpace(nombreForm))
                return null;

            string nombre = nombreForm.Trim();

            // 1) Intento directo (funciona si viene el FullName)
            var tipo = Type.GetType(nombre)
                       ?? Assembly.GetExecutingAssembly().GetType(nombre);
            if (EsFormulario(tipo)) return tipo;

            // 2) Buscar en TODOS los ensamblados cargados (por FullName, Name o EndsWith)
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                // Evitar ensamblados del sistema para no ralentizar
                if (asm.IsDynamic) continue;

                Type[] tipos;
                try { tipos = asm.GetTypes(); }
                catch (ReflectionTypeLoadException ex)
                {
                    tipos = ex.Types.Where(t => t != null).ToArray()!;
                }
                catch { continue; }

                // 2.a) Coincidencia por FullName exacto
                var encontrado = tipos.FirstOrDefault(t =>
                    EsFormulario(t) &&
                    string.Equals(t.FullName, nombre, StringComparison.OrdinalIgnoreCase));

                if (encontrado != null) return encontrado;

                // 2.b) Coincidencia por Name simple (ej. "frmUsuarios")
                encontrado = tipos.FirstOrDefault(t =>
                    EsFormulario(t) &&
                    string.Equals(t.Name, nombre, StringComparison.OrdinalIgnoreCase));

                if (encontrado != null) return encontrado;

                // 2.c) Si viene con namespace parcial "Forms.frmUsuarios" → EndsWith
                encontrado = tipos.FirstOrDefault(t =>
                    EsFormulario(t) &&
                    t.FullName != null &&
                    t.FullName.EndsWith("." + nombre, StringComparison.OrdinalIgnoreCase));

                if (encontrado != null) return encontrado;
            }

            return null;
        }

        private static bool EsFormulario(Type? t)
        {
            return t != null
                   && typeof(Form).IsAssignableFrom(t)
                   && !t.IsAbstract
                   && !t.IsInterface;
        }
    }
}
