using DomainLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.BrandVM;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();

            List<CategoryVM> categoryVM = new();

            foreach (var category in categories.OrderByDescending(m => m.Id))
            {
                categoryVM.Add(new CategoryVM
                {
                    Id = category.Id,
                    Name = category.Name,
                    Image = category.Image
                });
            }
            return View(categoryVM);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var category = await _categoryService.GetByIdAsync((int)id);

            CategoryDetailVM details = new()
            {
                Name = category.Name,
                Image = category.Image,
                CreateDate = category.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null) return BadRequest();

            await _categoryService.DeleteAsync((int)id);
            return Ok();
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CategoryAddVM request)
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


            await _categoryService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Category category = await _categoryService.GetByIdAsync((int)id);

            if (category == null) return NotFound();

            CategoryEditVM model = new()
            {
                Name = category.Name,
                Images = category.Image
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CategoryEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var brand = await _categoryService.GetByIdAsync((int)id);

            if (brand == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                request.Images = brand.Image;
                return View(request);
            }

            if (request.NewImage != null)
            {

                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Please select only an image file.");
                    request.Images = brand.Image;
                    return View(request);
                }

                if (request.NewImage.CheckFileSize(20000))
                {
                    ModelState.AddModelError("NewImage", "The image size must be a maximum of 200KB.");
                    request.Images = brand.Image;
                    return View(request);
                }
            }

            await _categoryService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
    }
}
