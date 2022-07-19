using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers
{
    public class ContactController : Controller
    {

        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<TopHeader> _topheader;
        public ContactController(IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
        }

        public IActionResult Index()
        {

           var gelenler =  _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            return View(gelenler);
        }

    }
}
