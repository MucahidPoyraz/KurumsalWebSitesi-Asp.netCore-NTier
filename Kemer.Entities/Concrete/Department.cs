using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class Department : BaseEntity
    {
        public string DepartmanName { get; set; }

        public List<Personel> Personels { get; set; }
    }
}
