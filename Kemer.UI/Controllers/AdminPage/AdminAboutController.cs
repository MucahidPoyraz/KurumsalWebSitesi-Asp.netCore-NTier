using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers
{
    public class AdminAboutController : Controller
    {
        
        private readonly IGenericService<About> _service;

       

        public AdminAboutController(IGenericService<About> service)
        {

            _service = service;
           
        }

        [Authorize]
        public IActionResult AboutListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            
            return View(gelenler);
        }

        [Authorize]
        public IActionResult AboutEkle()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AboutEkle(About p)
        {
           
            if (!ModelState.IsValid)
            { 
                return View("AboutEkle",p);
            }
            
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
             return RedirectToAction("AboutListele");
            
        }
        [Authorize]
        public IActionResult AboutSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("AboutListele");
        }
        [Authorize]
        public IActionResult AboutGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);
           
            return View("AboutEkle", guncellenecek);
        }

        [HttpPost]
        public IActionResult AboutGuncelle(About p)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("AboutEkle", p);
            }
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şekilde yapıldı";
            _service.GuncelleBl(p);
            return RedirectToAction("AboutListele");
        }
    }
}
