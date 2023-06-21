using Microsoft.AspNetCore.Identity;
using DomainLayer.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ServiceLayer.ViewModels.AccountVM;

namespace Fiorello.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;
        private readonly IHttpContextAccessor _accessor;

        public AccountService(UserManager<AppUser> userManager,
                              SignInManager<AppUser> signInManager,
                              RoleManager<IdentityRole> roleManager,
                              IEmailService emailService,
                              IHttpContextAccessor accessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailService = emailService;
            _accessor = accessor;
        }

        public async Task<IdentityResult> CreateUserAsync(RegisterVM request)
        {
            AppUser user = new()
            {
                UserName = request.UserName,
                Email = request.Email,
                FullName = request.FullName
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            return result;
        }

        public async Task AddUserToRoleAsync(AppUser user, Roles role)
        {
            await _userManager.AddToRoleAsync(user, role.ToString());
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(AppUser user)
        {
            string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            return token;
        }

        public async Task SendConfirmationEmailAsync(AppUser user, string link,string subject, string confirmationProp)
        {
            string html = EmailTemplate(link, user, confirmationProp);
             _emailService.Send(user.Email, subject, html);
        }
        public string EmailTemplate(string link, AppUser user, string confirmationProp)
        {
            string html = string.Empty;
            using (StreamReader reader = new("wwwroot/template/account.html"))
            {
                html = reader.ReadToEnd();
            }

            html = html.Replace("{{link}}", link);
            html = html.Replace("{{confirmationProp}}", confirmationProp);
            html = html.Replace("{{fullname}}", user.FullName);

            return html;
        }

        public async Task ConfirmEmailAsync(string userId, string token)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);
            await _userManager.ConfirmEmailAsync(user, token);
        }

        public async Task<SignInResult> PasswordSignInAsync(string emailOrUsername, string password)
        {
            AppUser user = await GetUserByEmailOrUsername(emailOrUsername);

            if (user == null)
            {
                return SignInResult.Failed;
            }

            var result = await _signInManager.PasswordSignInAsync(user, password, false, false);
            return result;
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task CreateRolesAsync()
        {
            foreach (var role in Enum.GetValues(typeof(Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(role.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
                }
            }
        }

        public async Task<AppUser> GetUserByEmailOrUsername(string emailUsername)
        {
            AppUser user = await _userManager.FindByEmailAsync(emailUsername);

            user ??= await _userManager.FindByNameAsync(emailUsername);

            return user;
        }
        public async Task<AppUser> GetUserById(string userId)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);
            return user;
        }

        public async Task SignInUserAsync(AppUser user)
        {
            await _signInManager.SignInAsync(user, false);
        }

        public async Task<ProfileVM> ProfileDataAsync()
        {
            var userId = _accessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            return new ProfileVM { UserEmail = user.Email, UserFullName = user.FullName };
        }

        public async Task<AppUser> ForgotPasswordAsync(string email)
        {
            AppUser existUser = await _userManager.FindByEmailAsync(email);

            return existUser;
        }
        public async Task<AppUser> ConfirmForgotPasswordAsync(string id)
        {
            AppUser userId = await _userManager.FindByIdAsync(id);
            
            return userId;
        }
        public async Task<string> GeneratePasswordResetTokenAsync(AppUser user)
        {
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return token;
        }

        public async Task<bool> ResetPasswordAsync(AppUser user,string password, string token)
        {
            if(await _userManager.CheckPasswordAsync(user, password))
            {
                return false;
            }
            await _userManager.ResetPasswordAsync(user, token, password);

            return true;
        }
    }
}
