using Microsoft.AspNetCore.Mvc;

namespace Grenny.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
