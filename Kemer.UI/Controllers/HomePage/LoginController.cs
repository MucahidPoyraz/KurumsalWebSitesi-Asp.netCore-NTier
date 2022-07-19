using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.Controllers
{
    public class LoginController : Controller
    {

        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<TopHeader> _topheader;
        public LoginController(IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
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

        public IActionResult LoginKontrol(Identity p)
        {
            //var info = c.Identities.FirstOrDefault(x => x.Email == p.Email &&
            //                                         x.Password == p.Password);

            //if (info != null)
            //{
            //    return RedirectToAction("AboutListele", "AdminAbout");
            //}
            ViewBag.Keywolrd = _keyworld.HepsiniGetirBl().FirstOrDefault();
            return RedirectToAction("Index", "Login");

        }

        public IActionResult SingUp()
        {
            return View();
        }
    }
}
