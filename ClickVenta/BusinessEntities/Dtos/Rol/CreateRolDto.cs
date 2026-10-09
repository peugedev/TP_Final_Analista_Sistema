using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Rol
{
    public class CreateRolDto : BaseDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
