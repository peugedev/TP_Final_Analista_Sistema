using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Menu: BaseEntity
    {
        public string Nombre { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string IconUrl { get; set; }
        public string Url { get; set; }

    }
}
