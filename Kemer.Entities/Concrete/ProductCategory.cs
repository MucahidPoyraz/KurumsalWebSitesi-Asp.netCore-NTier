using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class ProductCategory : BaseEntity
    {
        public string ProductCategoryName { get; set; }

        public List<Product> Products { get; set; }

    }
}
