using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kemer.UI.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly IGenericService<Blog> _blog;
        private readonly IGenericService<Contact> _contact;
        private readonly IGenericService<Keyworld> _keyworld;
        private readonly IGenericService<TopHeader> _topheader;

        public BlogDetailController(IGenericService<Blog> blog, IGenericService<Contact> contact, IGenericService<Keyworld> keyworld, IGenericService<TopHeader> topheader)
        {
            _blog = blog;
            _contact = contact;
            _keyworld = keyworld;
            _topheader = topheader;
        }

     
        public IActionResult Index(int id)
        {
            ViewBag.Blog = _blog.IdileGetirBl(id);
            ViewBag.Contact = _contact.HepsiniGetirBl().FirstOrDefault();
            ViewBag.Keyworld = _keyworld.HepsiniGetirBl().FirstOrDefault();
            ViewBag.TopHeader = _topheader.HepsiniGetirBl().FirstOrDefault();
            return View();
        }
    }
}
