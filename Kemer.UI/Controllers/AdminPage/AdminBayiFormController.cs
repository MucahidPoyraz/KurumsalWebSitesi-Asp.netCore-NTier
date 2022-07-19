using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers.AdminPage
{
    public class AdminBayiFormController : Controller
    {
        private readonly IGenericService<BayiForm> _bayiform;

        public AdminBayiFormController(IGenericService<BayiForm> bayiform)
        {
            _bayiform = bayiform;
        }

        public IActionResult BayiFormListele()
        {
            var gelenler = _bayiform.HepsiniGetirBl();
            return View(gelenler);
        }

        public IActionResult BayiFormSil(int id)
        {
            _bayiform.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("BayiFormListele");
        }
    }
}
