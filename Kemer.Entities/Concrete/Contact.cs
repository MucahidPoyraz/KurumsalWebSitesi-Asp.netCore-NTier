using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class Contact : BaseEntity
    {
        public string Address { get; set; }

        public string PhoneOne { get; set; }

        public string PhoneTwo { get; set; }

        public string EmailOne { get; set; }

        public string EmailTwo { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        public string Facebook { get; set; }

        public string Youtube { get; set; }

        public string WebSite { get; set; }

        public string MapLink { get; set; }


    }
}
