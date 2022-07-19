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
    public class AdminSliderController : Controller
    {
      
        private readonly IGenericService<Slider> _service;

        public AdminSliderController(IGenericService<Slider> service)
        {
            _service = service;
          
        }
        [Authorize]
        public IActionResult SliderListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult SliderEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SliderEkle(Slider p, IFormFile ImageUrl)
        {
            if (!ModelState.IsValid)
            {
                return View("SliderEkle", p);
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
            return RedirectToAction("SliderListele");
        }
        [Authorize]
        public IActionResult SliderSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("SliderListele");
        }
        [Authorize]
        public IActionResult SliderGuncelle(int id)
        {

            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);

            return View("SliderEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> SliderGuncelle(Slider p,IFormFile ImageUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("SliderEkle", p);
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
            //else
            //{
                
            //        p.ImageUrl = p.ImageUrl;
            //}

            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şekilde yapıldı";
            return RedirectToAction("SliderListele");
        }
    }
}
