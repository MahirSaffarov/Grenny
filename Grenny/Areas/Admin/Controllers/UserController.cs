using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Grenny.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }
        //public async Task<IActionResult> Details(string id)
        //{
        //    var user = await _userManager.FindByIdAsync(id);

        //    if (user == null)
        //    {
        //        // Handle user not found error
        //    }

        //    return View(user);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Delete(string id)
        //{
        //    var user = await _userManager.FindByIdAsync(id);

        //    if (user == null)
        //    {
        //        // Handle user not found error
        //    }

        //    var result = await _userManager.DeleteAsync(user);

        //    if (result.Succeeded)
        //    {
        //        return Json(new { success = true });
        //    }
        //    else
        //    {
        //        // Handle delete error
        //        return Json(new { success = false });
        //    }
        //}
        //[HttpPost]
        //public async Task<IActionResult> Block(string id, bool block)
        //{
        //    var user = await _userManager.FindByIdAsync(id);

        //    if (user == null)
        //    {
        //        // Handle user not found error
        //    }

        //    user.IsBlocked = block;

        //    var result = await _userManager.UpdateAsync(user);

        //    if (result.Succeeded)
        //    {
        //        return Json(new { success = true });
        //    }
        //    else
        //    {
        //        // Handle update error
        //        return Json(new { success = false });
        //    }
        //}


    }
}
