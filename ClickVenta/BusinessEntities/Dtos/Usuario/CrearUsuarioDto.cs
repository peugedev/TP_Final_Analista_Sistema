using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Usuario
{
    public class CrearUsuarioDto
    {
        public string EmpleadoId { get; set; }
        public string RolId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
    }
}
