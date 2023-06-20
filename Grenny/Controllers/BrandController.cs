using Microsoft.AspNetCore.Mvc;

namespace Grenny.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
