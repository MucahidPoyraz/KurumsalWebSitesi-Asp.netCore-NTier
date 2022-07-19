using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<TopHeader> _topheader;

        private readonly IGenericService<Slider> _slider;

        private readonly IGenericService<WhoWeAre> _whoweare;

        private readonly IGenericService<Personel> _personel;

        private readonly IGenericService<Referance> _referance;

        private readonly IGenericService<Service> _service;

        private readonly IGenericService<Contact> _contact;

        private readonly IWebHostEnvironment _env;

        private readonly IGenericService<Info> _info;

        private readonly IGenericService<Keyworld> _keyworld;

        private readonly IGenericService<ServiceCategory> _servicecategory;


        public HomeController(IGenericService<TopHeader> topheader, IGenericService<WhoWeAre> whoweare, IGenericService<Slider> slider, IGenericService<Referance> referance, IGenericService<Personel> personel, IGenericService<Service> service, IWebHostEnvironment env, IGenericService<Contact> contact, IGenericService<Info> info, IGenericService<Keyworld> keyworld, IGenericService<ServiceCategory> servicecategory)
        {
            _topheader = topheader;
            _whoweare = whoweare;
            _slider = slider;
            _referance = referance;
            _personel = personel;
            _service = service;
            _env = env;
            _contact = contact;
            _info = info;
            _keyworld = keyworld;
            _servicecategory = servicecategory;
        }




        public IActionResult Index()        
        {
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();

            ViewBag.WhoWeAre = _whoweare.HepsiniGetirBl().FirstOrDefault();

            ViewBag.Slider = _slider.HepsiniGetirBl().FirstOrDefault();

            ViewBag.Service = _service.HepsiniGetirBl("ServiceCategory");

            ViewBag.Personel = _personel.HepsiniGetirBl("Department");

            ViewBag.Referance = _referance.HepsiniGetirBl();
            ViewBag.ServiceCategory = _servicecategory.HepsiniGetirBl();


            return View();
        }

        public IActionResult Info(Info p)
        {
            _info.EkleBl(p);
            return RedirectToAction("Index");
        }

    }
}
