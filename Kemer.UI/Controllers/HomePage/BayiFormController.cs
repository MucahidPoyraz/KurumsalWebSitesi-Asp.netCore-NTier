using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers
{
    public class BayiFormController : Controller
    {
        private readonly IGenericService<BayiForm> _bayiform;
        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<TopHeader> _topheader;

        public BayiFormController(IGenericService<BayiForm> bayiform, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
            _bayiform = bayiform;
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
        }

        public IActionResult Index()
        {
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            return View();
        }

        public IActionResult BayiKayıt(BayiForm p)
        {
            _bayiform.EkleBl(p);
            return RedirectToAction("Index", "Home");
        }


    }
}
