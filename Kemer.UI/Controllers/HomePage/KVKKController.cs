using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers.HomePage
{

    public class KVKKController : Controller
    {
        private readonly IGenericService<Identity> _ıdentity;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<TopHeader> _topheader;

        public KVKKController(IGenericService<Identity> ıdentity, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
            _ıdentity = ıdentity;
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
        }

        public IActionResult Index()
        {
            var gelen = _contact.HepsiniGetirBl().FirstOrDefault();

            ViewBag.Contact = gelen;
            ViewBag.Websitesi = gelen.WebSite;
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            return View();
        }
    }
}
