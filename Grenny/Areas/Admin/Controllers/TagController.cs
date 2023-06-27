using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.TagVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagController : Controller
    {
        private readonly ITagService _tagService;
        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<IActionResult> Index()
        {
            var tags = await _tagService.GetAllAsync();

            List<TagVM> tagVM = new();

            foreach (var tag in tags.OrderByDescending(m => m.Id))
            {
                tagVM.Add(new TagVM
                {
                    Id = tag.Id,
                    Name = tag.Name
                });
            }
            return View(tagVM);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var tag = await _tagService.GetByIdAsync((int)id);

            TagDetailVM details = new()
            {
                Name = tag.Name,
                CreateDate = tag.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(TagAddVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _tagService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Tag tag = await _tagService.GetByIdAsync((int)id);

            if (tag == null) return NotFound();

            TagEditVM model = new()
            {
                Name = tag.Name
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(TagEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var tag = await _tagService.GetByIdAsync((int)id);

            if (tag == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _tagService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();

            await _tagService.DeleteAsync((int)id);
            return Ok();
        }
    }
}
