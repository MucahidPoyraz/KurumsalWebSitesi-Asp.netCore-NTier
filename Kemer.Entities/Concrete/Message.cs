using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemer.Entities.Concrete
{
    public class Message : BaseEntity
    {

        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string SendMessage { get; set; }

        public DateTime MessageaTime { get; set; } = DateTime.Now;

    }
}
