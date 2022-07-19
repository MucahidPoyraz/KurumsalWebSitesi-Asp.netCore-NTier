using System;

namespace Kemer.Entities.Concrete
{
    public class Blog : BaseEntity
    {
        public string ImageUrlOne { get; set; } = "defult.png";

        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string AuthorName { get; set; } = "Admin";

        public string Header { get; set; }

        public string SubTitle { get; set; }

        public string ContentOne { get; set; }

        public string ImageUrlTwo { get; set; } = "defult.png";

        public string ContentTwo { get; set; }

       

    }
}
