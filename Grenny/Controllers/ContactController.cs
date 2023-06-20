using Microsoft.AspNetCore.Mvc;

namespace Grenny.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
