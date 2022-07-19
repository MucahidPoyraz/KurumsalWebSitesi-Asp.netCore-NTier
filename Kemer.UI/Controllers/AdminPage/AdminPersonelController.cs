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
using static System.Net.WebRequestMethods;

namespace Kemer.UI.Controllers
{
    public class AdminPersonelController : Controller
    {
       
        private readonly IGenericService<Personel> _service;

        private readonly IGenericService<Department> _department;

        public AdminPersonelController(IGenericService<Personel> service, IGenericService<Department> department)
        {
            _service = service;
            _department = department;
        }
        [Authorize]
        public IActionResult PersonelListele()
        {
            var gelenler = _service.HepsiniGetirBl("Department");
            return View(gelenler);
        }
        [Authorize]
        public IActionResult PersonelEkle()
        {

            List<SelectListItem> degerler = (from x in _department.HepsiniGetirBl()
                                             select new SelectListItem
                                             {
                                                 Text = x.DepartmanName,
                                                 Value = x.Id.ToString()

                                             }).ToList();
            ViewBag.Department = degerler;


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PersonelEkle(Personel p, IFormFile ImageUrlOne)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> degerler = (from x in _department.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.DepartmanName,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.Department = degerler;
                return View("PersonelEkle", p);
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
           
            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("PersonelListele");
        }
        [Authorize]
        public IActionResult PersonelSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("PersonelListele");
        }
        [Authorize]
        public IActionResult PersonelGuncelle(int id)
        {
            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);
            List<SelectListItem> degerler = (from x in _department.HepsiniGetirBl()
                                             select new SelectListItem
                                             {
                                                 Text = x.DepartmanName,
                                                 Value = x.Id.ToString()

                                             }).ToList();
            ViewBag.Department = degerler;

            return View("PersonelEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> PersonelGuncelle(Personel p,IFormFile ImageUrlOne)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> degerler = (from x in _department.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.DepartmanName,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.Department = degerler;
                ViewBag.state = "update";
                return View("PersonelEkle", p);
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
            
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şekilde yapıldı";
            return RedirectToAction("PersonelListele");
        }
    }
}
