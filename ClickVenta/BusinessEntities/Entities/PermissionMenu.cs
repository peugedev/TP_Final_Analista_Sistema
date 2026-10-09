using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class PermissionMenu: BaseEntity
    {
        public string Name { get; set; }
        public string SubMenuId { get; set; }
        public string SubMenuName { get; set; }
        public string formAssociation { get; set; }
        public int IsAssigned { get; set; }
    }
}
