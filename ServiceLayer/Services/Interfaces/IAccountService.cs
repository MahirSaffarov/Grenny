using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity;
using ServiceLayer.Helpers;
using ServiceLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUserAsync(RegisterVM request);
        Task AddUserToRoleAsync(AppUser user, Roles role);
        Task<string> GenerateEmailConfirmationTokenAsync(AppUser user);
        Task<string> GeneratePasswordResetTokenAsync(AppUser user);
        Task SendConfirmationEmailAsync(AppUser user, string link);
        Task ConfirmEmailAsync(string userId, string token);
        Task<SignInResult> PasswordSignInAsync(string emailOrUsername, string password);
        Task SignOutAsync();
        Task CreateRolesAsync();
        Task<AppUser> GetUserByEmailOrUsername(string emailOrUsername);
        Task<AppUser> GetUserById(string userId);
        Task SignInUserAsync(AppUser user);
        Task<ProfileVM> ProfileDataAsync();
        Task<AppUser> ForgotPasswordAsync(string email);
        Task<AppUser> ConfirmForgotPasswordAsync(string id);
        Task<bool> ResetPasswordAsync(AppUser user, string password,string token);
    }
}
