using DomainLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;
using ServiceLayer.ViewModels.AdminVM.TeamVM;
using Microsoft.AspNetCore.Authorization;
namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var teams = await _teamService.GetAllAsync();

            List<TeamVM> teamVM = new();

            foreach (var team in teams.OrderByDescending(m => m.Id))
            {
                teamVM.Add(new TeamVM
                {
                    Id = team.Id,
                    Name = team.Name,
                    Image = team.Image,
                    About = team.About,
                    Position = team.Position
                });
            }
            return View(teamVM);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var team = await _teamService.GetByIdAsync((int)id);

            TeamDetailVM details = new()
            {
                Name = team.Name,
                Image = team.Image,
                CreateDate = team.CreateDate.ToString("dd/MMMM/yyyy"),
                Position = team.Position,
                About = team.About
            };

            return View(details);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null) return BadRequest();

            await _teamService.DeleteAsync((int)id);
            return Ok();
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(TeamAddVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            if (!request.Image.CheckFileType("image/"))
            {
                ModelState.AddModelError("Image", "Please select only image file.");
                return View(request);
            }

            if (request.Image.CheckFileSize(2000))
            {
                ModelState.AddModelError("Image", "Please select under 200KB image");
                return View(request);
            }


            await _teamService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Team team = await _teamService.GetByIdAsync((int)id);

            if (team == null) return NotFound();

            TeamEditVM model = new()
            {
                Name = team.Name,
                Image = team.Image,
                About = team.About,
                Position = team.Position
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TeamEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var team = await _teamService.GetByIdAsync((int)id);

            if (team == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                request.Image = team.Image;
                return View(request);
            }

            if (request.NewImage != null)
            {

                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Please select only an image file.");
                    request.Image = team.Image;
                    return View(request);
                }

                if (request.NewImage.CheckFileSize(20000))
                {
                    ModelState.AddModelError("NewImage", "The image size must be a maximum of 200KB.");
                    request.Image = team.Image;
                    return View(request);
                }
            }

            await _teamService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
    }
}
