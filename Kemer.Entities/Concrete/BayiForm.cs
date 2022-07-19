using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class BayiForm : BaseEntity
    {

        public string Unvan { get; set; }

        public int FaaliyetYılı { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Adress { get; set; }

        public string Sehir { get; set; }

        public string WebSitesi { get; set; }
    }
}
