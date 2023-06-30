using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.SliderInfoVM;
using ServiceLayer.ViewModels.AdminVM.SliderVM;
using Microsoft.AspNetCore.Authorization;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderInfoController : Controller
    {
        private readonly ISliderInfoService _sliderInfoService;
        public SliderInfoController(ISliderInfoService sliderInfoService)
        {
            _sliderInfoService = sliderInfoService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var sliderInfos = await _sliderInfoService.GetAllAsync();

            List<SliderInfoVM> sliderInfoVM = new();

            foreach (var sliderInfo in sliderInfos.OrderByDescending(m => m.Id))
            {
                sliderInfoVM.Add(new SliderInfoVM
                {
                    Id = sliderInfo.Id,
                    Text = sliderInfo.Text,
                    Title = sliderInfo.Title
                });
            }

            return View(sliderInfoVM);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            SliderInfo sliderInfos = await _sliderInfoService.GetByIdAsync((int)id);

            SliderInfoDetailVM details = new()
            {
                Text = sliderInfos.Title,
                Title = sliderInfos.Text,
                CreateDate = sliderInfos.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(SliderInfoCreateVM request)
        {
            if (!ModelState.IsValid) return View();
            
            SliderInfoCreateVM sliderInfoCreateVM = new()
            {
                Text= request.Text,
                Title = request.Title
            };

            await _sliderInfoService.CreateAsync(sliderInfoCreateVM);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _sliderInfoService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            SliderInfo sliderInfo = await _sliderInfoService.GetByIdAsync((int)id);

            if (sliderInfo == null) return NotFound();

            return View(new SliderInfoEditVM { Id = sliderInfo.Id,Title = sliderInfo.Title, Text = sliderInfo.Text });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, SliderInfoEditVM request)
        {
            if (id is null) return BadRequest();

            SliderInfo sliderInfo = await _sliderInfoService.GetByIdAsync((int)id);

            if (sliderInfo == null) return NotFound();

            await _sliderInfoService.EditAsync(sliderInfo, request);

            return RedirectToAction(nameof(Index));

        }
    }
}
