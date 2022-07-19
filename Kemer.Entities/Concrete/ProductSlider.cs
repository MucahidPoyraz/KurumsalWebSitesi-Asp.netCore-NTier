using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class ProductSlider : BaseEntity
    {


        public string PruductImage { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
