using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers
{
    public class AdminDepartmentController : Controller
    {
       
        private readonly IGenericService<Department> _service;

        public AdminDepartmentController(IGenericService<Department> service)
        {
            
            _service = service;
        }


        [Authorize]
        public IActionResult DepartmentListele()
        {
            var gelenler = _service.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult DepartmentEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepartmentEkle(Department p)
        {
            if (!ModelState.IsValid)
            {
                return View("DepartmentEkle", p);
            }

            _service.EkleBl(p);
            TempData["Ekleme"] = "Ekleme işlemi başarı ile yapıldı";
            return RedirectToAction("DepartmentListele");
        }
        [Authorize]
        public IActionResult DepartmentSil(int id)
        {
            _service.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("DepartmentListele");
        }
        [Authorize]
        public IActionResult DepartmentGuncelle(int id)
        {

            ViewBag.state = "update";

            var guncellenecek = _service.IdileGetirBl(id);

            return View("DepartmentEkle", guncellenecek);
        }

        [HttpPost]
        public IActionResult DepartmentGuncelle(Department p)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.state = "update";
                return View("DepartmentEkle", p);
            }
            _service.GuncelleBl(p);
            TempData["Guncellendi"] = "Guncelleme işlemi başarılı bir şkilde yapıldı";
            return RedirectToAction("DepartmentListele");
        }
    }
}
