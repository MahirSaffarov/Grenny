using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DAL;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AccountVM;
using System.Security.Claims;

namespace Grenny.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IBasketService _basketService;
        private readonly IWishlistService _wishlistService;

        public AccountController(IAccountService accountService,
                                 IBasketService basketService,
                                 IWishlistService wishlistService)
        {
            _accountService = accountService;
            _basketService = basketService;
            _wishlistService = wishlistService;
        }

        [HttpGet]
        public IActionResult SignUp() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(RegisterVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _accountService.CreateUserAsync(request);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(request);
            }

            AppUser user = await _accountService.GetUserByEmailOrUsername(request.Email);

            await _accountService.AddUserToRoleAsync(user, Roles.Member);

            await _basketService.CreateAsync(user);
            await _wishlistService.CreateAsync(user);
            
           string token = await _accountService.GenerateEmailConfirmationTokenAsync(user);

            string link = GenerateConfirmationEmailLink(user.Id, token, "ConfirmEmail");
            string subject = "Email for register Confirmation";
            string confirmationProp = "confirm your email address";
            await _accountService.SendConfirmationEmailAsync(user, link,subject, confirmationProp);

            return RedirectToAction(nameof(VerifyEmail));
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null) return BadRequest();

            await _accountService.ConfirmEmailAsync(userId, token);

            AppUser user = await _accountService.GetUserById(userId);
            
            await _accountService.SignInUserAsync(user);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult VerifyEmail() => View();

        [HttpGet]
        public IActionResult SignIn() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(LoginVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _accountService.PasswordSignInAsync(request.EmailOrUsername, request.Password);

            if (result.ToString() == "Failed")
            {
                ModelState.AddModelError(string.Empty, "Email or password is wrong");
                return View(request);
            }

            if (result.IsNotAllowed)
            {
                ModelState.AddModelError(string.Empty, "Please confirm your account");
                return View(request);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _accountService.SignOutAsync();
            return RedirectToAction(nameof(SignIn));
        }

        public async Task<IActionResult> CreateRoles()
        {
            await _accountService.CreateRolesAsync();

            return Ok();
        }

        private string GenerateConfirmationEmailLink(string userId, string token, string action)
        {
            string link = Url.Action(action, "Account", new { userId = userId, token }, Request.Scheme);
            
            return link;
        }

        [HttpGet]
        public IActionResult ForgotPassword() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            
            var existUser = await _accountService.ForgotPasswordAsync(request.Email);

            if(existUser is null)
            {
                ModelState.AddModelError("Email", "User not found");
                return View(request);
            }

            string token = await _accountService.GeneratePasswordResetTokenAsync(existUser);

            string link = GenerateConfirmationEmailLink(existUser.Id, token, "ResetPassword");
            string subject = "Password reset Confirmation";
            string confirmationProp = "reset your password";
            await _accountService.SendConfirmationEmailAsync(existUser, link,subject, confirmationProp);

            return RedirectToAction(nameof(VerifyEmail));
        }

        [HttpGet]
        public async Task<IActionResult> ResetPassword(string userId,string token) => View(new ResetPasswordVM { Token = token,UserId=userId});

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM request)
        {
            if (!ModelState.IsValid) return View(request);

            AppUser existUser = await _accountService.ConfirmForgotPasswordAsync(request.UserId);

            if (existUser is null) return NotFound();

            if(!await _accountService.ResetPasswordAsync(existUser, request.Password, request.Token))
            {
                ModelState.AddModelError("Password", "New password can not be same with old password");
                return View(request);
            }


            return RedirectToAction(nameof(SignIn));

        }
        public async Task<IActionResult> Profile()
        {
            return View(await _accountService.ProfileDataAsync());
        }
    }
}
