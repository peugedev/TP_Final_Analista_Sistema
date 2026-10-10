using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.ProveedorProducto
{
    public class ProveedorProductoDto : BaseDto
    {
        public string ProveedorId { get; set; }
        public string ProductoId { get; set; }
    }
}
