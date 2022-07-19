using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kemer.UI.Controllers
{
    public class AdminServiceContentController : Controller
    {
       
        
        private readonly IServiceContentService _serviceContentService;
        private readonly IGenericService<Service> _service;



        public AdminServiceContentController(IServiceContentService serviceContentService, IGenericService<Service> service)
        {

            _serviceContentService = serviceContentService;
            _service = service;
        }
        [Authorize]
        public IActionResult ServiceContentListele(int id)
        {
            var gelenler = _serviceContentService.DetaylarıGetirBl(id);
            ViewBag.ServiceId = id;
            return View(gelenler);
        }
        [Authorize]
        public IActionResult ServiceContentEkle(int id)
        {
            ViewBag.ServiceId = id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ServiceContentEkle(ServiceContent p, IFormFile ImageUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ServiceId = p.ServiceId;

                return View("ServiceContentEkle", p);
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
           
            _serviceContentService.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            
            var Id = p.ServiceId;
            return RedirectToAction("ServiceContentListele", new { id = Id });
        }
        [Authorize]
        public IActionResult ServiceContentSil(int id)
        {
            var gelen = _serviceContentService.IdileGetirBl(id);
            var Id = gelen.ServiceId;
            _serviceContentService.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
          
            return RedirectToAction("ServiceContentListele", new { id = Id });
        }
        [Authorize]
        public IActionResult ServiceContentGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _serviceContentService.IdileGetirBl(id);


            return View("ServiceContentEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> ServiceContentGuncelle(ServiceContent p,IFormFile ImageUrl)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> degerler = (from x in _service.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.HeaderOne,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.Service = degerler;
                ViewBag.state = "update";
                return View("ServiceContentEkle", p);
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
            
            _serviceContentService.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            var Id = p.ServiceId;
            return RedirectToAction("ServiceContentListele", new { id = Id });
        }
    }
}
