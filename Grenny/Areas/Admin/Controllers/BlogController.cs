using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.BlogVM;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ITeamService _teamService;
        public BlogController(ITeamService teamService,
                              IBlogService blogService)
        {
            _teamService = teamService;
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            var blogs = await _blogService.GetAllWithIncludes();

            List<BlogVM> blogVM = new();

            foreach (var blog in blogs.OrderByDescending(m => m.Id))
            {
                blogVM.Add(new BlogVM
                {
                    Id = blog.Id,
                    Image = blog.Image,
                    Text = blog.Text,
                    Title = blog.Title,
                    Team = blog.Team.Name
                });
            }
            return View(blogVM);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var blog = await _blogService.GetByIdWithAllIncludesAsync((int)id);

            BlogDetailVM details = new()
            {
                Image = blog.Image,
                CreateDate = blog.CreateDate.ToString("dd/MMMM/yyyy"),
                Text = blog.Text,
                Title = blog.Title,
                Team = blog.Team.Name
            };

            return View(details);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null) return BadRequest();

            await _blogService.DeleteAsync((int)id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            await GetAllSelectOptions();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(BlogAddVM request)
        {
            await GetAllSelectOptions();

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


            await _blogService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Blog blog = await _blogService.GetByIdWithAllIncludesAsync((int)id);

            if (blog == null) return NotFound();

            await GetAllSelectOptions();

            BlogEditVM model = new()
            {
                Images = blog.Image,
                Title = blog.Title,
                TeamId = blog.TeamId,
                Text = blog.Text
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BlogEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            await GetAllSelectOptions();

            var blog = await _blogService.GetByIdWithAllIncludesAsync((int)id);

            if (blog == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                request.Images = blog.Image;
                return View(request);
            }

            if (request.NewImage != null)
            {

                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Please select only an image file.");
                    request.Images = blog.Image;
                    return View(request);
                }

                if (request.NewImage.CheckFileSize(20000))
                {
                    ModelState.AddModelError("NewImage", "The image size must be a maximum of 200KB.");
                    request.Images = blog.Image;
                    return View(request);
                }
            }

            await _blogService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
        private async Task GetAllSelectOptions()
        {
            ViewBag.teams = await GetTeams();
        }
        private async Task<SelectList> GetTeams()
        {
            IEnumerable<Team> teams = await _teamService.GetAllAsync();
            return new SelectList(teams, "Id", "Name");
        }
    }
}
