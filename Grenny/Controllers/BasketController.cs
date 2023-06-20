using Microsoft.AspNetCore.Mvc;

namespace Grenny.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
