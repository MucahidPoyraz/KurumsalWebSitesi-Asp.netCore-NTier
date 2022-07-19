using Kemer.BL.Abstract;
using Kemer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kemer.UI.Controllers
{
    public class AdminInfoController : Controller
    {
        private readonly IGenericService<Info> _info;

        public AdminInfoController(IGenericService<Info> info)
        {
            _info = info;
        }

        public IActionResult InfoListele()
        {
            var gelenler = _info.HepsiniGetirBl();
            return View(gelenler);
        }

        public IActionResult InfoSil(int id)
        {
            _info.SilBl(id);
            return RedirectToAction("InfoListele");
        }
    }
}
