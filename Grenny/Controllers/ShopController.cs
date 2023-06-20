using Microsoft.AspNetCore.Mvc;

namespace Grenny.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
