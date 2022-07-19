using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class BlogCategory : BaseEntity
    {
        public string BlogCategoryName { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
