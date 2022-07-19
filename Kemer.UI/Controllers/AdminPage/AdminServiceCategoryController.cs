using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Kemer.UI.Controllers
{
    public class AdminServiceCategoryController : Controller
    {
       
        private readonly IGenericService<ServiceCategory> _service;

        public AdminServiceCategoryController(IGenericService<ServiceCategory> service)
        {
            _service = service;
          
        }
        [Authorize]
        public IActionResult ServiceCategoryListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult ServiceCategoryEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ServiceCategoryEkle(ServiceCategory p, IFormFile CategoryIcon)
        {
            if (!ModelState.IsValid)
            {
                return View("ServiceCategoryEkle", p);
            }
            if (CategoryIcon != null)
            {
                string uzanti = Path.GetExtension(CategoryIcon.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    CategoryIcon.CopyToAsync(stream);
                }

                p.CategoryIcon = resimAd;

            }
            else
            {
                p.CategoryIcon = "default.jpg";
            }
           
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("ServiceCategoryListele");
        }
        [Authorize]
        public IActionResult ServiceCategorySil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("ServiceCategoryListele");
        }
        [Authorize]
        public IActionResult ServiceCategoryGuncelle(int id)
        {

            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);

            return View("ServiceCategoryEkle", guncellenecek);
        }

        [HttpPost]
        public IActionResult ServiceCategoryGuncelle(ServiceCategory p,IFormFile CategoryIcon)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("ServiceCategoryEkle", p);
            }
            if (CategoryIcon != null)
            {
                string uzanti = Path.GetExtension(CategoryIcon.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    CategoryIcon.CopyToAsync(stream);
                }

                p.CategoryIcon = resimAd;

            }
           
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("ServiceCategoryListele");
        }
    }
}
