using FluentValidation;
using FluentValidation.AspNetCore;
using Kemer.BL.Abstract;
using Kemer.BL.Concrete;
using Kemer.BL.ValidtaionRules;
using Kemer.Dal.Abstract;
using Kemer.Dal.Concrete.EntityFramwork;
using Kemer.Entities.Concrete;
using Kemer.UI.Middleware;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Kemer.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddMvc(setup =>
            {
                //...mvc setup...
            }).AddFluentValidation();


            services.AddTransient<IValidator<About>, AboutValidator>();
            services.AddTransient<IValidator<Blog>, BlogValidator>();
            services.AddTransient<IValidator<BlogCategory>, BlogCategoryValidator>();
            services.AddTransient<IValidator<Contact>, ContactValidator>();
            services.AddTransient<IValidator<Department>, DepartmentValidator>();
            services.AddTransient<IValidator<Identity>, IdentityValidator>();
            services.AddTransient<IValidator<Message>, MessageValidator>();
            services.AddTransient<IValidator<Personel>, PersonelValidator>();
            services.AddTransient<IValidator<Product>, ProductValidator>();
            services.AddTransient<IValidator<ProductCategory>, ProductCategoryValidator>();
            services.AddTransient<IValidator<Referance>, ReferanceValidator>();
            services.AddTransient<IValidator<Service>, ServiceValidator>();
            services.AddTransient<IValidator<ServiceCategory>, ServiceCategoryValidator>();
            services.AddTransient<IValidator<ServiceContent>, ServiceContentValidator>();
            services.AddTransient<IValidator<Slider>, SliderValidator>();
            services.AddTransient<IValidator<TopHeader>, TopHeaderValidator>();
            services.AddTransient<IValidator<WhoWeAre>, WhoWeAreValidator>();


            services.AddTransient(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddTransient(typeof(IGenericRepository<>), typeof(EfGenericRepository<>));

            services.AddScoped<IServiceContentService, ServiceContentService>();
            services.AddScoped<IProductSliderService, ProductSliderService>();



            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(optinos =>
            {
                optinos.LoginPath = "/Yonetim/Index/";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseAuthentication();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseDeveloperExceptionPage();





            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.UseSitemapMiddleware();
            app.UseDeveloperExceptionPage();

        }
    }
}
