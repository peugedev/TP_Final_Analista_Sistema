using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Presentacion : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Navigation property removed to avoid compile-time dependency
        // public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
