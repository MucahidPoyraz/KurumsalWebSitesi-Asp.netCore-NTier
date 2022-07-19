using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers
{
    public class AdminBlogCategoryController : Controller
    {
     
        private readonly IGenericService<BlogCategory> _blogcategory;

        public AdminBlogCategoryController(IGenericService<BlogCategory> blogcategory)
        {

            _blogcategory = blogcategory;
        }


        [Authorize]
        public IActionResult BlogCategoryListele()
        {
            var gelenler = _blogcategory.HepsiniGetirBl();
            return View(gelenler);
        }

        public IActionResult BlogCategoryEkle()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult BlogCategoryEkle(BlogCategory p)
        {
            if (!ModelState.IsValid)
            {
                return View("BlogCategoryEkle", p);
            }

            _blogcategory.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("BlogCategoryListele");
        }

        public IActionResult BlogCategorySil(int id)
        {
            _blogcategory.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("BlogCategoryListele");
        }

        public IActionResult BlogCategoryGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _blogcategory.IdileGetirBl(id);
            return View("BlogCategoryEkle", guncellenecek);


           
        }

        [HttpPost]
        public IActionResult BlogCategoryGuncelle(BlogCategory p)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("BlogCategoryEkle", p);
            }
            _blogcategory.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("BlogCategoryListele");
        }
    }
}
