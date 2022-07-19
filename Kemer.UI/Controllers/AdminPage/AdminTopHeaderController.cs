using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers
{
    public class AdminTopHeaderController : Controller
    {
        private readonly IGenericService<TopHeader> _service;

        public AdminTopHeaderController(IGenericService<TopHeader> service)
        {
            _service = service;
        }

        [Authorize]
        public IActionResult TopHeaderListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult TopHeaderEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TopHeaderEkle(TopHeader p)
        {
            if (!ModelState.IsValid)
            {
                return View("TopHeaderEkle", p);
            }
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("TopHeaderListele");
        }
        [Authorize]
        public IActionResult TopHeaderSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("TopHeaderListele");
        }
        [Authorize]
        public IActionResult TopHeaderGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);


            return View("TopHeaderEkle", guncellenecek);
        }

        [HttpPost]
        public IActionResult TopHeaderGuncelle(TopHeader p)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("TopHeaderEkle", p);
            }
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("TopHeaderListele");
        }
    }
}
