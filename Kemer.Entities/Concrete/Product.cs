using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class Product : BaseEntity
    {

        public string ImageUrlOne { get; set; }

        public string Header { get; set; }

        public string SubTitle { get; set; }

        public string Content { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public List<ProductSlider> ProductSliders { get; set; }


    }
}
