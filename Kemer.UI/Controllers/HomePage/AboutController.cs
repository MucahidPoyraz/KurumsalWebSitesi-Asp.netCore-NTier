using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers
{
    public class AboutController : Controller
    {

        private readonly IGenericService<About> _service;
        private readonly IGenericService<TopHeader> _topheader;
        private readonly IGenericService<Personel> _personel;

        private readonly IGenericService<Referance> _referance;

        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<Contact> _contact;

        public AboutController(IGenericService<About> service, IGenericService<Personel> personel, IGenericService<Referance> referance, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
            _service = service;
            _personel = personel;
            _referance = referance;
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
        }

        public IActionResult Index()
        {
           var gelen = _service.HepsiniGetirBl().FirstOrDefault();
           ViewBag.Personeller = _personel.HepsiniGetirBl("Department");
            ViewBag.Referance = _referance.HepsiniGetirBl();
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            return View(gelen);
        }

      



    }
}
