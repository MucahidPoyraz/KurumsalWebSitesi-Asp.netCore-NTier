using System;
using System.Collections.Generic;
using System.Text;

namespace Kemer.Entities.Concrete
{
    public class Sitemap : BaseEntity
    {
        public string Loc { get; set; }
        public string Priority { get; set; }
        public string ChangeFreq { get; set; }
        public string LastModified { get; set; }
    }
}
