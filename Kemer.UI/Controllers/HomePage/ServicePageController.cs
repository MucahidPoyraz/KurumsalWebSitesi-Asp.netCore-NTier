using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers
{
    public class ServicePageController : Controller
    {
        private readonly IGenericService<Service> _service;
        private readonly IGenericService<Request> _request;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<TopHeader> _topheader;


        public ServicePageController(IGenericService<Service> service, IGenericService<Request> request, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
            _service = service;
            _request = request;
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
        }

        public IActionResult Index()
        {

            var gelenler = _service.HepsiniGetirBl("ServiceCategory");
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            return View(gelenler);
        }

        public IActionResult ServiceRequest(Request p)
        {
            _request.EkleBl(p);
           return RedirectToAction("Index");
        }



    }
}
