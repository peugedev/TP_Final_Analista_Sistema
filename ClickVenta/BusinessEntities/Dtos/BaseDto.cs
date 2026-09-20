using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos
{
    public class BaseDto
    {
        public string Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaBaja { get; set; }
        public int Estado { get; set; }
    }
}
