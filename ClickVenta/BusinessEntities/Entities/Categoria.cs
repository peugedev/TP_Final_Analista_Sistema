using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Categoria: BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //public List<Producto> Productos { get; set; }
        public List<SubCategoria> SubCategorias { get; set; }
    }
}
