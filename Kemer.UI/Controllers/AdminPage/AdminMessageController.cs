using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers
{
    public class AdminMessageController : Controller
    {
       
        private readonly IGenericService<Message> _service;

        public AdminMessageController(IGenericService<Message> service)
        {
            _service = service;
        
        }
        [Authorize]
        public IActionResult MessageListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }

        public IActionResult MessageEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessageEkle(Message p)
        {
            if (!ModelState.IsValid)
            {
                return View("MessageEkle", p);
            }
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("MessageListele");
        }
        [Authorize]
        public IActionResult MessageSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("MessageListele");
        }
        [Authorize]
        public IActionResult MessageGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);


            return View("MessageEkle", guncellenecek);
        }

        [HttpPost]
        public IActionResult MessageGuncelle(Message p)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("MessageEkle", p);
            }
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("MessageListele");
        }

        [HttpPost]
        public IActionResult MessageGonder(Message p)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Contact",p);
            }
            _service.EkleBl(p);

            return RedirectToAction("Index","Contact");
        }

    }
}
