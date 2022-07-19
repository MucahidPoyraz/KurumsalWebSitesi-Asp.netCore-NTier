using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class ServiceContent : BaseEntity
    {

        public string ImageUrl { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
