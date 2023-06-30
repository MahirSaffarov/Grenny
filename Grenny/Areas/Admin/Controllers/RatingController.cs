using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.RatingVM;
using Microsoft.AspNetCore.Authorization;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public async Task<IActionResult> Index()
        {
            var ratings = await _ratingService.GetAllAsync();

            List<RatingVM> ratingVM = new();

            foreach (var rating in ratings.OrderByDescending(m => m.Id))
            {
                ratingVM.Add(new RatingVM
                {
                    Id = rating.Id,
                    RatingCount = rating.RatingCount,
                });
            }
            return View(ratingVM);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var rating = await _ratingService.GetByIdAsync((int)id);

            RatingDetailVM details = new()
            {
                RatingCount = rating.RatingCount,
                CreateDate = rating.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(RatingAddVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _ratingService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Rating rating = await _ratingService.GetByIdAsync((int)id);

            if (rating == null) return NotFound();

            RatingEditVM model = new()
            {
                RatingCount = rating.RatingCount,
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(RatingEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var rating = await _ratingService.GetByIdAsync((int)id);

            if (rating == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _ratingService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();

            await _ratingService.DeleteAsync((int)id);
            return Ok();
        }
    }
}
