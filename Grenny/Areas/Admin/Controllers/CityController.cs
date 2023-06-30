using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;
using ServiceLayer.ViewModels.AdminVM.CityVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        public async Task<IActionResult> Index()
        {
            var cities = await _cityService.GetAllAsync();

            List<CityVM> cityVM = new();

            foreach (var city in cities.OrderByDescending(m => m.Id))
            {
                cityVM.Add(new CityVM
                {
                    Id = city.Id,
                    Name = city.Name,
                    Image = city.Image,
                    Address = city.Address
                });
            }
            return View(cityVM);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var city = await _cityService.GetByIdAsync((int)id);

            CityDetailVM details = new()
            {
                Name = city.Name,
                Image = city.Image,
                Address = city.Address,
                CreateDate = city.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null) return BadRequest();

            await _cityService.DeleteAsync((int)id);
            return Ok();
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CityAddVM request)
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


            await _cityService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            City city = await _cityService.GetByIdAsync((int)id);

            if (city == null) return NotFound();

            CityEditVM model = new()
            {
                Name = city.Name,
                Images = city.Image,
                Address = city.Address
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CityEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var city = await _cityService.GetByIdAsync((int)id);

            if (city == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                request.Images = city.Image;
                return View(request);
            }

            if (request.NewImage != null)
            {

                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Please select only an image file.");
                    request.Images = city.Image;
                    return View(request);
                }

                if (request.NewImage.CheckFileSize(20000))
                {
                    ModelState.AddModelError("NewImage", "The image size must be a maximum of 200KB.");
                    request.Images = city.Image;
                    return View(request);
                }
            }

            await _cityService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
    }
}
