using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers
{
    public class BlogController : Controller
    {

        private readonly IGenericService<Blog> _blog;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<TopHeader> _topheader;
        private readonly IGenericService<BlogCategory> _blogCategory;



        public BlogController(IGenericService<Blog> blog, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader, IGenericService<BlogCategory> blogCategory)
        {
            _blog = blog;
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
            _blogCategory = blogCategory;
        }

        public IActionResult Index()
        {

            var gelenler = _blog.HepsiniGetirBl("BlogCategory");
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            ViewBag.BlogCategory = _blogCategory.HepsiniGetirBl();
            return View(gelenler);
        }

        
       

    }
}
