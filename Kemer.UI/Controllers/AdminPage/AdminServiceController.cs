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
    public class AdminServiceController : Controller
    {
     
        private readonly IGenericService<Service> _service;

        private readonly IGenericService<ServiceCategory> _servicecategory;

        public AdminServiceController(IGenericService<Service> service, IGenericService<ServiceCategory> servicecategory)
        {
            _service = service;
            _servicecategory = servicecategory;
        }
        [Authorize]
        public IActionResult ServiceListele()
        {
            var gelenler = _service.HepsiniGetirBl("ServiceCategory");
            return View(gelenler);
        }
        [Authorize]
        public IActionResult ServiceEkle()
        {
            List<SelectListItem> degerler = (from x in _servicecategory.HepsiniGetirBl()
                                             select new SelectListItem
                                             {
                                                 Text = x.ServiceCategoryName,
                                                 Value = x.Id.ToString()

                                             }).ToList();
            ViewBag.ServiceCategory = degerler;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ServiceEkle(Service p, IFormFile ImageUrlOne, IFormFile ImageUrlTwo)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> degerler = (from x in _servicecategory.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.ServiceCategoryName,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.ServiceCategory = degerler;
                return View("ServiceEkle", p);
            }
            if (ImageUrlOne != null)
            {
                string uzanti = Path.GetExtension(ImageUrlOne.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                  await  ImageUrlOne.CopyToAsync(stream);
                }

                p.ImageUrlOne = resimAd;

            }
            else
            {
                p.ImageUrlOne = "default.jpg";
            }

            if (ImageUrlOne != null)
            {
                string uzanti2 = Path.GetExtension(ImageUrlTwo.FileName);
                string resimAd2 = Guid.NewGuid() + uzanti2;
                string path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd2);

                using (var stream = new FileStream(path2, FileMode.Create))
                {
                   await ImageUrlTwo.CopyToAsync(stream);
                }

                p.ImageUrlTwo = resimAd2;

            }
            else
            {
                p.ImageUrlTwo = "default.jpg";
            }
            
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("ServiceListele");
        }
        [Authorize]
        public IActionResult ServiceSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("ServiceListele");
        }
        [Authorize]
        public IActionResult ServiceGuncelle(int id)
        {
            ViewBag.state = "update";

            List<SelectListItem> degerler = (from x in _servicecategory.HepsiniGetirBl()
                                             select new SelectListItem
                                             {
                                                 Text = x.ServiceCategoryName,
                                                 Value = x.Id.ToString()

                                             }).ToList();
            ViewBag.ServiceCategory = degerler;

            var guncellenecek = _service.IdileGetirBl(id);


            return View("ServiceEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> ServiceGuncelle(Service p, IFormFile ImageUrlOne, IFormFile ImageUrlTwo)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> degerler = (from x in _servicecategory.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.ServiceCategoryName,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.ServiceCategory = degerler;
                ViewBag.state = "update";
                return View("ServiceEkle", p);
            }

            if (ImageUrlOne != null)
            {
                string uzanti = Path.GetExtension(ImageUrlOne.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                   await ImageUrlOne.CopyToAsync(stream);
                }

                p.ImageUrlOne = resimAd;

            }
            else
            {
                p.ImageUrlOne = "default.jpg";
            }

            if (ImageUrlTwo != null)
            {
                string uzanti2 = Path.GetExtension(ImageUrlTwo.FileName);
                string resimAd2 = Guid.NewGuid() + uzanti2;
                string path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd2);

                using (var stream = new FileStream(path2, FileMode.Create))
                {
                  await  ImageUrlTwo.CopyToAsync(stream);
                }

                p.ImageUrlTwo = resimAd2;

            }
            
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("ServiceListele");
        }
    }
}
