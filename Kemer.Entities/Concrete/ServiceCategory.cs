using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class ServiceCategory : BaseEntity
    {
        public string ServiceCategoryName{ get; set; }

        public string CategoryIcon { get; set; }

        public List<Service> Services { get; set; }
    }
}
