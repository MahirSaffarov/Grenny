using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.Interfaces;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllAsync();
            return View(users);
        }
        public async Task<IActionResult> Detail(string id)
        {
            if (id is null) return BadRequest();

            var user = await _userService.GetByIdAsync(id);

            if (user == null) return NotFound();

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            if (id is null) return BadRequest();

            var user = await _userService.GetByIdAsync(id);

            if (user == null) return NotFound();

            await _userService.DeleteAsync(user);

            return Ok();
        }
    }
}
