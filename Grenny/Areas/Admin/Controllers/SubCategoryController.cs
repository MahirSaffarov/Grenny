using DomainLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using ServiceLayer.ViewModels.AdminVM.SubCategoryVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;
        public SubCategoryController(ICategoryService categoryService,
                                     ISubCategoryService subCategoryService)
        {  
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
        }
        public async Task<IActionResult> Index()
        {
            var subCategories = await _subCategoryService.GetAllWithIncludes();

            List<SubCategoryVM> subCategoryVM = new();

            foreach (var subCategory in subCategories.OrderByDescending(m=>m.Id))
            {
                subCategoryVM.Add(new SubCategoryVM
                {
                    Id = subCategory.Id,
                    Name = subCategory.Name,
                    Category = subCategory.Category.Name
                });
            }
            return View(subCategoryVM);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var subCategory = await _subCategoryService.GetByIdWithAllIncludesAsync(id);

            SubCategoryDetailVM details = new()
            {
                Name = subCategory.Name,
                Category = subCategory.Category.Name,
                CreateDate = subCategory.CreateDate.ToString("dddd,MMMM,yyyy")
            };
            return View(details);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            await GetAllSelectOptions();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(SubCategoryAddVM request)
        {
            await GetAllSelectOptions();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _subCategoryService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null) return BadRequest();

            await _subCategoryService.DeleteAsync((int)id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            SubCategory subCategory = await _subCategoryService.GetByIdWithAllIncludesAsync((int)id);

            if (subCategory == null) return NotFound();

            await GetAllSelectOptions();

            SubCategoryEditVM model = new()
            {
                Name = subCategory.Name,
                CategoryId = subCategory.CategoryId
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubCategoryEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            await GetAllSelectOptions();

            var subCategory = await _subCategoryService.GetByIdWithAllIncludesAsync((int)id);

            if (subCategory == null)
                return NotFound();

            await _subCategoryService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
        private async Task GetAllSelectOptions()
        {
            ViewBag.categories = await GetCategories();
        }
        private async Task<SelectList> GetCategories()
        {
            IEnumerable<Category> categories = await _categoryService.GetAllAsync();
            return new SelectList(categories, "Id", "Name");
        }
    }
}
