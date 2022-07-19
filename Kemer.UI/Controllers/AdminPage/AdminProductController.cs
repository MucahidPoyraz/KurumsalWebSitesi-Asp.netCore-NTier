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
    public class AdminProductController : Controller
    {
       
        private readonly IGenericService<Product> _product;
        private readonly IGenericService<ProductCategory> _productcategory;

        public AdminProductController(IGenericService<Product> product, IGenericService<ProductCategory> productcategory)
        {
            _product = product;
            _productcategory = productcategory;
        }
        [Authorize]
        public IActionResult ProductListele()
        {
            var gelenler = _product.HepsiniGetirBl("ProductCategory");
            return View(gelenler);
        }
        [Authorize]
        public IActionResult ProductEkle()
        {

            List<SelectListItem> degerler = (from x in _productcategory.HepsiniGetirBl()
                                             select new SelectListItem
                                             {
                                                 Text = x.ProductCategoryName,
                                                 Value = x.Id.ToString()

                                             }).ToList();
            ViewBag.ProductCategory = degerler;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductEkle(Product p, IFormFile ImageUrlOne)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> degerler = (from x in _productcategory.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.ProductCategoryName,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.ProductCategory = degerler;
                return View("ProductEkle", p);
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

            _product.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";

            return RedirectToAction("ProductListele");
        }
        [Authorize]
        public IActionResult ProductSil(int id)
        {
            _product.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("ProductListele");
        }
        [Authorize]
        public IActionResult ProductGuncelle(int id)
        {
            List<SelectListItem> degerler = (from x in _productcategory.HepsiniGetirBl()
                                             select new SelectListItem
                                             {
                                                 Text = x.ProductCategoryName,
                                                 Value = x.Id.ToString()

                                             }).ToList();
            ViewBag.ProductCategory = degerler;
            ViewBag.state = "update";

            var guncellenecek = _product.IdileGetirBl(id);

            return View("ProductEkle", guncellenecek);
        }

        [HttpPost]
        public async Task<IActionResult> ProductGuncelle(Product p,IFormFile ImageUrlOne)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> degerler = (from x in _productcategory.HepsiniGetirBl()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.ProductCategoryName,
                                                     Value = x.Id.ToString()

                                                 }).ToList();
                ViewBag.ProductCategory = degerler;
                ViewBag.state = "update";
                return View("ProductEkle", p);
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
           
            _product.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("ProductListele");
        }
    }
}
