using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaBaja { get; set; }
        public int Estado { get; set; }
    }
}
