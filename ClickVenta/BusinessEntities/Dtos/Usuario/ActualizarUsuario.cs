using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Usuario
{
    public class ActualizarUsuario:BaseDto
    {
        public string EmpleadoId { get; set; }
        public string RolId { get; set; }
        public string Contrasena { get; set; }
    }
}
