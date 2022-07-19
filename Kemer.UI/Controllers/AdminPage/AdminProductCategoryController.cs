using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers
{
    public class AdminProductCategoryController : Controller
    {
      
        private readonly IGenericService<ProductCategory> _productcategory;

        public AdminProductCategoryController(IGenericService<ProductCategory> productcategory)
        {
          
            _productcategory = productcategory;
        }
        [Authorize]
        public IActionResult ProductCategoryListele()
        {
            var gelenler = _productcategory.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult ProductCategoryEkle()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult ProductCategoryEkle(ProductCategory p)
        {
            if (!ModelState.IsValid)
            {
                return View("ProductCategoryEkle", p);
            }
            _productcategory.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("ProductCategoryListele");
        }
        [Authorize]
        public IActionResult ProductCategorySil(int id)
        {
            _productcategory.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("ProductCategoryListele");
        }
        [Authorize]
        public IActionResult ProductCategoryGuncelle(int id)
        {

            ViewBag.state = "update";

            var guncellenecek = _productcategory.IdileGetirBl(id);

            return View("ProductCategoryEkle", guncellenecek);
        }

        [HttpPost]
        public IActionResult ProductCategoryGuncelle(ProductCategory p)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("ProductCategoryEkle", p);
            }
            _productcategory.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("ProductCategoryListele");
        }
    }
}
