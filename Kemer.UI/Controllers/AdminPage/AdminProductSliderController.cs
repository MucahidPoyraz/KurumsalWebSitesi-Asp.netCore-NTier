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
    public class AdminProductSliderController : Controller
    {

        private readonly IProductSliderService _productSliderService;

        public AdminProductSliderController(IProductSliderService productSliderService)
        {
            _productSliderService = productSliderService;
        }


        [Authorize]
        public IActionResult ProductSliderListele(int id)
        {
            var gelenler = _productSliderService.DetaylarıGetirBl(id);
            ViewBag.ProductId = id;
            return View(gelenler);
        }

        [Authorize]
        public IActionResult ProductSliderEkle(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductSliderEkle(ProductSlider p, IFormFile PruductImage)
        {
            if (PruductImage != null)
            {
                string uzanti = Path.GetExtension(PruductImage.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                   await PruductImage.CopyToAsync(stream);
                }

                p.PruductImage = resimAd;

            }
            else
            {
                p.PruductImage = "default.jpg";
            }
            
            _productSliderService.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile eklendi";
            var id = p.ProductId;
            return RedirectToAction("ProductSliderListele",new {id = id});
           

        }
        [Authorize]
        public IActionResult ProductSliderSil(int id)
        {
            var gelen = _productSliderService.IdileGetirBl(id);
            var Id = gelen.ProductId;
            _productSliderService.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";

            return RedirectToAction("ProductSliderListele", new { id = Id });
        }
        [Authorize]
        public IActionResult ProductSliderGuncelle(int id)
        {
            ViewBag.state = "update";
            var guncellenecek = _productSliderService.IdileGetirBl(id);
            return View("ProductSliderEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> ProductSliderGuncelle(ProductSlider p, IFormFile PruductImage)
        {
            if (PruductImage != null)
            {
                string uzanti = Path.GetExtension(PruductImage.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await PruductImage.CopyToAsync(stream);
                }

                p.PruductImage = resimAd;

            }
           
            var Id = p.ProductId;
            _productSliderService.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("ProductSliderListele", new { id = Id });
        }
    }


}

