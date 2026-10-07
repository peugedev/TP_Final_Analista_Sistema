using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class DetallePago : BaseEntity
    {
        public int IdFormaPago { get; set; }
        public int IdVenta { get; set; }
        public string? Observaciones { get; set; }
    }
}
