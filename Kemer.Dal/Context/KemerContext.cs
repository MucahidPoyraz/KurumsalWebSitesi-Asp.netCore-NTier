using Kemer.Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DemircanAmbalaj.Dal.Context
{
    public class KemerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server =45.143.97.3; database =KemerDB; user id=kurumsal2; password=1FiveAjans; MultipleActiveResultSets=True;");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Identity> Identities { get; set; }

        public DbSet<Message> Messajes { get; set; }

        public DbSet<Personel> Personels { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Referance> Referances { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ServiceCategory> ServiceCategories { get; set; }

        public DbSet<ServiceContent> serviceContents { get; set; }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<TopHeader> TopHeaders { get; set; }

        public DbSet<WhoWeAre> WhoWeAres { get; set; }

        public DbSet<ProductSlider> ProductSliders { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<BayiForm> BayiForms { get; set; }

        public DbSet<Sitemap> Sitemaps { get; set; }

        public DbSet<Info> Infos { get; set; }

        public DbSet<Keyworld> Keyworlds { get; set; }

    }
}
