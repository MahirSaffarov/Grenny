using DomainLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.BrandVM;
using ServiceLayer.ViewModels.AdminVM.ProductVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        public async Task<IActionResult> Index()
        {
            var brands = await _brandService.GetAllAsync();

            List<BrandVM> brandVM = new();

            foreach (var brand in brands.OrderByDescending(m => m.Id))
            {
                brandVM.Add(new BrandVM
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    Image = brand.Image
                });
            }
            return View(brandVM);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var brand = await _brandService.GetByIdAsync(id);

            BrandDetailVM details = new()
            {
                Name = brand.Name,               
                Image = brand.Image,
                CreateDate = brand.CreateDate.ToString("dd/MMMM/yyyy")
            };
            return View(details);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(BrandAddVM request)
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


            await _brandService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null) return BadRequest();

            await _brandService.DeleteAsync((int)id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Brand brand = await _brandService.GetByIdAsync((int)id);

            if (brand == null) return NotFound();

            BrandEditVM model = new()
            {
                Name = brand.Name,
                Images = brand.Image
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BrandEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var brand = await _brandService.GetByIdAsync((int)id);

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

            await _brandService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
    }
}
