using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AboutPageVM;
using ServiceLayer.ViewModels.Service;
using ServiceLayer.ViewModels.Social;
using ServiceLayer.ViewModels.Team;

namespace Grenny.Controllers
{
    public class AboutController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly ISocialService _socialService;
        private readonly IServiceService _serviceService;

        public AboutController(ITeamService teamService, 
                               ISocialService socialService, 
                               IServiceService serviceService)
        {
            _teamService = teamService;
            _socialService = socialService;
            _serviceService = serviceService;
        }
        public async Task<IActionResult> Index()
        {
            var teams = await _teamService.GetAllAsync();
            var socials = await _socialService.GetAllAsync();
            var services = await _serviceService.GetAllAsync();

            var teamVM = new List<TeamVM>();
            var socialVM = new List<SocialVM>();
            var serviceVM = new List<ServiceVM>();

            var teamViewModels = teams.Select(member => new TeamVM
            {
                Name = member.Name,
                Position = member.Position,
                About = member.About,
                Image = member.Image
            });
            var socialViewModels = socials.Select(member => new SocialVM
            {
                Name = member.Name,
                Icon = member.Icon
            });
            var serviceViewModels = services.Select(member => new ServiceVM
            {
                Text = member.Text,
                Title = member.Title
            });

            var aboutViewModel = new AboutPageVM
            {
                TeamVM = teamViewModels,
                SocialVM = socialViewModels,
                ServiceVM = serviceViewModels
            };

            return View(aboutViewModel);
        }
    }
}
