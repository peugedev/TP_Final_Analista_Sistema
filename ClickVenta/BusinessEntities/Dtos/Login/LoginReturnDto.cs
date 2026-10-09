using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Login
{
    public class LoginReturnDto
    {
        public string Id { get; set; }
        public string EmpleadoId { get; set; }
        public string NombreUsuario { get; set; }
        public string RolId { get; set; }        
    }
}
