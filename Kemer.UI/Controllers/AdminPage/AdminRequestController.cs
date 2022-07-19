using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers.AdminPage
{
    public class AdminRequestController : Controller
    {
        private readonly IGenericService<Request> _request;

        public AdminRequestController(IGenericService<Request> request)
        {
            _request = request;
        }
        [Authorize]
        public IActionResult RequestListele()
        {
            var gelenler = _request.HepsiniGetirBl();
            return View(gelenler);
        }
        [Authorize]
        public IActionResult RequestSil(int id)
        {

            _request.SilBl(id);
            TempData["Silindi"] = "Silme işlemi başarılı";
            return RedirectToAction("RequestListele");
        }
    }
}
