using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.SocialVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        private readonly ISocialService _socialService;
        public SocialController(ISocialService socialService)
        {
            _socialService = socialService;
        }

        public async Task<IActionResult> Index()
        {
            var socials = await _socialService.GetAllAsync();

            List<SocialVM> socialVM = new();

            foreach (var social in socials.OrderByDescending(m => m.Id))
            {
                socialVM.Add(new SocialVM
                {
                    Id = social.Id,
                    Name = social.Name,
                    Icon = social.Icon
                });
            }
            return View(socialVM);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var social = await _socialService.GetByIdAsync((int)id);

            SocialDetailVM details = new()
            {
                Name = social.Name,
                CreateDate = social.CreateDate.ToString("dd/MMMM/yyyy"),
                Icon = social.Icon
            };

            return View(details);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(SocialAddVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _socialService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Social social = await _socialService.GetByIdAsync((int)id);

            if (social == null) return NotFound();

            SocialEditVM model = new()
            {
                Name = social.Name,
                Icon = social.Icon
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SocialEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var discount = await _socialService.GetByIdAsync((int)id);

            if (discount == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _socialService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();

            await _socialService.DeleteAsync((int)id);
            return Ok();
        }
    }
}
