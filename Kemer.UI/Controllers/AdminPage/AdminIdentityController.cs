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
    public class AdminIdentityController : Controller
    {
        
        private readonly IGenericService<Identity> _service;

        public AdminIdentityController(IGenericService<Identity> service)
        {
           
            _service = service;
        }
        [Authorize]
        public IActionResult IdentityListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult IdentityEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IdentityEkle(Identity p, IFormFile ImageUrl)
        {
            if (!ModelState.IsValid)
            {
                return View("IdentityEkle", p);
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
            return RedirectToAction("IdentityListele");
        }
        [Authorize]
        public IActionResult IdentitySil(int id)
        {
            _service.SilBl(id);
             TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("IdentityListele");
        }
        [Authorize]
        public IActionResult IdentityGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);


            return View("IdentityEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> IdentityGuncelle(Identity p,IFormFile ImageUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("IdentityEkle", p);
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
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("IdentityListele");
        }
    }
}
