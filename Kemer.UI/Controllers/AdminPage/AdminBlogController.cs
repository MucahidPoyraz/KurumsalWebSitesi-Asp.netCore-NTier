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
    public class AdminBlogController : Controller
    {
     
        private readonly IGenericService<Blog> _blog;
        private readonly IGenericService<BlogCategory> _blogcategory;

        public AdminBlogController(IGenericService<Blog> blog, IGenericService<BlogCategory> blogcategory)
        {

            _blog = blog;
            _blogcategory = blogcategory;
        }
        [Authorize]
        public IActionResult BlogListele()
        {
            var gelenler = _blog.HepsiniGetirBl("BlogCategory");
            return View(gelenler);
        }
        [Authorize]
        public IActionResult BlogEkle()
        {

            List<SelectListItem> degerler = (from x in _blogcategory.HepsiniGetirBl()
                                             select new SelectListItem
                                             {
                                                 Text = x.BlogCategoryName,
                                                 Value = x.Id.ToString()

                                             }).ToList();
            ViewBag.BlogCategory = degerler;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BlogEkle(Blog p, IFormFile ImageUrlOne, IFormFile ImageUrlTwo)
        {
            if (!ModelState.IsValid)
            {

                List<SelectListItem> degerler = (from x in _blogcategory.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.BlogCategoryName,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.BlogCategory = degerler;
                return View("BlogEkle", p);
            }
            if (ImageUrlTwo != null)
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

           
            if(ImageUrlTwo != null) { 
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
            _blog.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("BlogListele");
        }
        [Authorize]
        public IActionResult BlogSil(int id)
        {
            _blog.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("BlogListele");
        }
        [Authorize]
        public IActionResult BlogGuncelle(int id)
        {
            ViewBag.state = "update";
            List<SelectListItem> degerler = (from x in _blogcategory.HepsiniGetirBl()
                                             select new SelectListItem
                                             {
                                                 Text = x.BlogCategoryName,
                                                 Value = x.Id.ToString()

                                             }).ToList();
            ViewBag.BlogCategory = degerler;
            var guncellenecek = _blog.IdileGetirBl(id);
            return View("BlogEkle", guncellenecek);


          
        }

        [HttpPost]
        public async Task<IActionResult> BlogGuncelle(Blog p,IFormFile ImageUrlOne, IFormFile ImageUrlTwo)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> degerler = (from x in _blogcategory.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.BlogCategoryName,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.BlogCategory = degerler;
                ViewBag.state = "update";
                return View("BlogEkle", p);
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
           

            if (ImageUrlTwo != null)
            {
                string uzanti = Path.GetExtension(ImageUrlTwo.FileName);
                string resimAd = Guid.NewGuid() + uzanti;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/imgs/" + resimAd);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                  await ImageUrlTwo.CopyToAsync(stream);
                }
                p.ImageUrlTwo = resimAd;
            }
            
            _blog.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şekilde yapıldı";
            return RedirectToAction("BlogListele");
        }
    }
}
