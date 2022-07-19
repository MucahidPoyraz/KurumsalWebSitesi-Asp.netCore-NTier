using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers.HomePage
{
    public class ProductDetailController : Controller
    {

        private readonly IProductSliderService _productSliderService;
        private readonly IGenericService<Product> _product;
        private readonly IGenericService<Request> _request;
        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<TopHeader> _topheader;
        public ProductDetailController(IProductSliderService productSliderService, IGenericService<Product> product, IGenericService<Request> request, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
            _productSliderService = productSliderService;
            _product = product;
            _request = request;
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
        }

        public IActionResult Index(int id)
        {
            var gelenler =  _productSliderService.DetaylarıGetirBl(id);
            ViewBag.Product = _product.IdileGetirBl(id);
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            return View(gelenler);
        }

        
       
        public IActionResult ProductRequest(Request p)
        {
            _request.EkleBl(p);
            return RedirectToAction("Index","Product");
        }
    }
}
