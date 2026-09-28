using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Categoria
{
    public class CreateCategoriaDto : BaseDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool Estado { get; set; } = true;
        //public List<ProductoDto>? Productos { get; set; } = new List<ProductoDto>();
    }
}
