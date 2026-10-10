using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class DetallePago : BaseEntity
    {
        public string FormaPagoId { get; set; }
        public string VentaId { get; set; }
        public string? Observaciones { get; set; }

        public FormaPago FormaPago { get; set; }
        public Venta Venta { get; set; }
    }
}
