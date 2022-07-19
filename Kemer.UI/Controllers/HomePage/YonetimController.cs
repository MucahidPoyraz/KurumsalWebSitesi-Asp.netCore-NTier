using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Kemer.UI.Controllers
{
    public class YonetimController : Controller
    {
        private readonly IGenericService<Identity> _ıdentity;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<TopHeader> _topheader;

        public YonetimController(IGenericService<Identity> ıdentity, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
            _ıdentity = ıdentity;
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
            var info = _ıdentity.HepsiniGetirBl().FirstOrDefault(x => x.Email == p.Email &&
                                                     x.Password == p.Password);

            if (info != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,"Admin")
                };
                var userIdentity = new ClaimsIdentity(claims, "Yonetim");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                HttpContext.SignInAsync(principal);

                return RedirectToAction("AboutListele", "AdminAbout");
            }
            return RedirectToAction("Index", "Yonetim");

        }
    }
}
