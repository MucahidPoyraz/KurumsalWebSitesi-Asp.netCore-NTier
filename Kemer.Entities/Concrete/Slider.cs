using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class Slider : BaseEntity
    {
        public string ImageUrl { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public string VideoLink { get; set; }

        public string ButonOne { get; set; }

        public string ButonOneLink { get; set; }

        public string ButtonTwo { get; set; }

        public string ButtonTwoLink { get; set; }
    }
}
