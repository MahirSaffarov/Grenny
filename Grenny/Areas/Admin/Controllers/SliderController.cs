using DomainLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.DAL;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.RatingVM;
using ServiceLayer.ViewModels.AdminVM.SliderVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet]
        public async Task<IActionResult> Index() 
        {
            var sliders = await _sliderService.GetAllAsync();

            List<SliderVM> sliderVM = new();

            foreach (var slider in sliders.OrderByDescending(m => m.Id))
            {
                sliderVM.Add(new SliderVM
                {
                    Id = slider.Id,
                    Image = slider.Image,
                    Status = slider.Status
                });
            }


            return View(sliderVM); 
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var slider = await _sliderService.GetByIdAsync((int)id);

            SliderDetailVM details = new()
            {
                Image = slider.Image,
                CreateDate = slider.CreateDate.ToString("dd/MMMM/yyyy"),
                Status = slider.Status
            };

            return View(details);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(SliderAddVM request)
        {
            if (!ModelState.IsValid) return View();

            foreach (var item in request.Images)
            {
                if (!item.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Image", "Please select only image file.");
                    return View();
                }

                if (item.CheckFileSize(2000))
                {
                    ModelState.AddModelError("Image", "Please select under 200KB image");
                    return View();
                }
            }

            await _sliderService.AddAsync(request.Images);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _sliderService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();

            Slider dbSlider = await _sliderService.GetByIdAsync((int)id);

            if (dbSlider is null) return NotFound();

            return View(new SliderEditVM { Image = dbSlider.Image });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, SliderEditVM request)
        {
            if (id is null) return BadRequest();

            Slider dbSlider = await _sliderService.GetByIdAsync((int)id);

            if (dbSlider is null) return NotFound();

            if (request.NewImage is null) return RedirectToAction(nameof(Index));

            if (!request.NewImage.CheckFileType("image/"))
            {
                ModelState.AddModelError("NewImage", "Please select only image file.");
                request.Image = dbSlider.Image;
                return View(request);
            }
            if (request.NewImage.CheckFileSize(2000))
            {
                ModelState.AddModelError("NewImage", "Image size must be max 200KB");
                request.Image = dbSlider.Image;
                return View(request);
            }

            await _sliderService.EditAsync(dbSlider, request.NewImage);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> ChangeStatus(int? id)
        {
            if (id is null) return BadRequest();

            Slider slider = await _sliderService.GetByIdAsync((int)id);

            if (slider is null) return NotFound();

            return Ok(await _sliderService.ChangeStatusAsync(slider));
        }
    }
}
