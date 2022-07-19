using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class Service : BaseEntity
    {
        public string ImageUrlOne { get; set; }

        public string ImageUrlTwo { get; set; }

        public string HeaderOne { get; set; }

        public string SubtitleOne { get; set; }

        public int ServiceCategoryID { get; set; }
        public ServiceCategory ServiceCategory { get; set; }

        public string VideoLink { get; set; }

        public string HeaderTwo { get; set; }

        public string SubtitleTwo { get; set; }

        public string Content { get; set; }

        public List<ServiceContent> ServiceContents { get; set; }
    }
}
