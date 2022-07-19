using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers
{
    public class ServiceDetailController : Controller
    {

        private readonly IGenericService<Service> _serviceContent;
        private readonly IServiceContentService _serviceContentService;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<TopHeader> _topheader;
        private readonly IGenericService<Request> _request;

        public ServiceDetailController(IGenericService<Service> serviceContent, IServiceContentService serviceContentService, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader, IGenericService<Request> request)
        {
            _serviceContent = serviceContent;
            _serviceContentService = serviceContentService;
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
            _request = request;
        }

        public IActionResult Index(int id)
        {
            var gelenler = _serviceContentService.DetaylarıGetirBl(id);
            var service = _serviceContent.IdileGetirBl(id);
            ViewBag.Service = service;
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            return View(gelenler);


        }

        public IActionResult ServiceRequest(Request p)
        {
            _request.EkleBl(p);
            return RedirectToAction("Index", "Service");
        }


    }
}
