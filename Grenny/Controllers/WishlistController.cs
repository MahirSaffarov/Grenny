using Microsoft.AspNetCore.Mvc;

namespace Grenny.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
