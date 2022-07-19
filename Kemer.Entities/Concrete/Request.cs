using System;

namespace Kemer.Entities.Concrete
{
    public class Request : BaseEntity
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime RequestTime { get; set; } = DateTime.Now;
    }
}
