using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Roles
{
    public class RolDto: BaseDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
