using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Usuario
{
    public class Usuario: BaseDto
    {
        public string EmpleadoId { get; set; }
        public string RolId { get; set; }
        public string NombreUsuario { get; set; }
    }
}
