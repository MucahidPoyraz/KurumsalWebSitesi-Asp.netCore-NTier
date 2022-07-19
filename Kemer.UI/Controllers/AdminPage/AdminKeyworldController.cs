using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Kemer.UI.Controllers.AdminPage
{
    public class AdminKeyworldController : Controller
    {
        private readonly IGenericService<Keyworld> _keywolrd;

        public AdminKeyworldController(IGenericService<Keyworld> keywolrd)
        {
            _keywolrd = keywolrd;
        }

        public IActionResult KeyworldListele()
        {
            var gelenler = _keywolrd.HepsiniGetirBl();
            return View(gelenler);
        }

        public IActionResult KeyworldEkle()
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> KeyworldEkle(Keyworld p, IFormFile icon)
        {
            if (icon != null)
            {
                string uzanti = Path.GetExtension(icon.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                   await icon.CopyToAsync(stream);
                }

                p.icon = resimAd;
            }
            else
            {
                p.icon = "default.jpg";
            }
            _keywolrd.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("KeyworldListele");
        }

        public IActionResult KeyworldSil(int id)
        {
            _keywolrd.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("KeyworldListele");
        }

        public IActionResult KeyworldGuncelle(int id)
        {
            ViewBag.state = "update";
            var gelenler =   _keywolrd.IdileGetirBl(id);
            return View("KeyworldEkle", gelenler);
        }

        [HttpPost]
        public async Task<IActionResult> KeyworldGuncelle(Keyworld p, IFormFile icon)
        {
            if (icon != null)
            {
                string uzanti = Path.GetExtension(icon.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                   await icon.CopyToAsync(stream);
                }

                p.icon = resimAd;
            }
           
            _keywolrd.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şekilde yapıldı";
            return RedirectToAction("KeyworldListele");
        }
    }
}
