using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class Personel : BaseEntity
    {
        public string PersonelNameSurname { get; set; }

        public string ImageUrlOne { get; set; }        

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public string Content { get; set; }


    }
}
