using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class ProveedorProducto : BaseEntity
    {
        public string ProveedorId { get; set; }
        public string ProductoId { get; set; }
    }
}
