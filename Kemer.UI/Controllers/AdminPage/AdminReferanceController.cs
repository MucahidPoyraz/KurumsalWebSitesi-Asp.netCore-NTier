using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Kemer.UI.Controllers
{
    public class AdminReferanceController : Controller
    {
     
        private readonly IGenericService<Referance> _service;

        public AdminReferanceController(IGenericService<Referance> service)
        {
            _service = service;
           
        }
        [Authorize]
        public IActionResult ReferanceListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult ReferanceEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ReferanceEkle(Referance p, IFormFile IconUrl)
        {
            if (!ModelState.IsValid)
            {
                return View("ReferanceEkle", p);
            }
            if (IconUrl != null)
            {
                string uzanti = Path.GetExtension(IconUrl.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                   await IconUrl.CopyToAsync(stream);
                }

                p.IconUrl = resimAd;

            }
            else
            {
                p.IconUrl = "default.jpg";
            }
            
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("ReferanceListele");
        }
        [Authorize]
        public IActionResult ReferanceSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("ReferanceListele");
        }
        [Authorize]
        public IActionResult ReferanceGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);


            return View("ReferanceEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> ReferanceGuncelle(Referance p,IFormFile IconUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("ReferanceEkle", p);
            }
            if (IconUrl != null)
            {
                string uzanti = Path.GetExtension(IconUrl.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                   await IconUrl.CopyToAsync(stream);
                }

                p.IconUrl = resimAd;

            }
           
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("ReferanceListele");
        }
    }
}
