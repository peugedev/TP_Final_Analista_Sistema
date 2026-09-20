using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Rol: BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
