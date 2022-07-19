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
    public class AdminWhoWeAreController : Controller
    {
       
        private readonly IGenericService<WhoWeAre> _service;

        public AdminWhoWeAreController(IGenericService<WhoWeAre> service )
        {
            
            _service = service;
        }


        [Authorize]
        public IActionResult WhoWeAreListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult WhoWeAreEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WhoWeAreEkle(WhoWeAre p, IFormFile ImageUrl)
        {
            if (!ModelState.IsValid)
            {
                return View("WhoWeAreEkle", p);
            }
            if (ImageUrl != null)
            {
                string uzanti = Path.GetExtension(ImageUrl.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                   await ImageUrl.CopyToAsync(stream);
                }

                p.ImageUrl = resimAd;
            }
            else
            {
                p.ImageUrl = "default.jpg";
            }
            
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("WhoWeAreListele");
        }
        [Authorize]
        public IActionResult WhoWeAreSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("WhoWeAreListele");
        }
        [Authorize]
        public IActionResult WhoWeAreGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);


            return View("WhoWeAreEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> WhoWeAreGuncelle(WhoWeAre p, IFormFile ImageUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("WhoWeAreEkle", p);
            }
            if (ImageUrl != null)
            {
                string uzanti = Path.GetExtension(ImageUrl.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ImageUrl.CopyToAsync(stream);
                }

                p.ImageUrl = resimAd;

            }

           
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şekilde yapıldı";
            return RedirectToAction("WhoWeAreListele");
        }
    }
}
