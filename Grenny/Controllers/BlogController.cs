using Microsoft.AspNetCore.Mvc;

namespace Grenny.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
