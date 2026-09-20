using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Usuario: BaseEntity
    {
        public string EmpleadoId { get; set; }
        public string RolId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Empleado Empleado { get; set; }
        public Rol Rol { get; set; }
    }
}
