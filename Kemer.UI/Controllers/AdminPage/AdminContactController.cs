using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers
{
    public class AdminContactController : Controller
    {
        
        private readonly IGenericService<Contact> _service;

        public AdminContactController( IGenericService<Contact> service)
        {           
            _service = service;
        }


        [Authorize]
        public IActionResult ContactListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult ContactEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactEkle(Contact p)
        {          
            if (!ModelState.IsValid)
            {                
                return View("ContactEkle", p);
            }
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("ContactListele");
        }
        [Authorize]
        public IActionResult ContactSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("ContactListele");
        }
        [Authorize]
        public IActionResult ContactGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);


            return View("ContactEkle", guncellenecek);
        }

        [HttpPost]
        public IActionResult ContactGuncelle(Contact p)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("ContactEkle", p);
            }
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şekilde yapıldı";
            return RedirectToAction("ContactListele");
        }
    }
}
