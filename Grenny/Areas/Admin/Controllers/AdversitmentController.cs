using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.AdversitmentVM;
using ServiceLayer.ViewModels.AdminVM.SliderVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdversitmentController : Controller
    {
        private readonly IAdversitmentService _adversitmentService;
        public AdversitmentController(IAdversitmentService adversitmentService)
        {
            _adversitmentService = adversitmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var adversitments = await _adversitmentService.GetAllAsync();

            List<AdversitmentVM> adversitmentVM = new();

            foreach (var adversitment in adversitments.OrderByDescending(m => m.Id))
            {
                adversitmentVM.Add(new AdversitmentVM
                {
                    Id = adversitment.Id,
                    Image = adversitment.Image
                });
            }

            return View(adversitmentVM);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var adversiment = await _adversitmentService.GetByIdAsync((int)id);

            AdversitmentDetailVM details = new()
            {
                Image = adversiment.Image,
                CreateDate = adversiment.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AdversitmentAddVM request)
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

            await _adversitmentService.AddAsync(request.Images);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();

            Adversiment adversiment = await _adversitmentService.GetByIdAsync((int)id);

            if (adversiment is null) return NotFound();

            return View(new AdversitmentEditVM { Image = adversiment.Image });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, AdversitmentEditVM request)
        {
            if (id is null) return BadRequest();

            Adversiment adversiment = await _adversitmentService.GetByIdAsync((int)id);

            if (adversiment is null) return NotFound();

            if (request.NewImage is null) return RedirectToAction(nameof(Index));

            if (!request.NewImage.CheckFileType("image/"))
            {
                ModelState.AddModelError("NewImage", "Please select only image file.");
                request.Image = adversiment.Image;
                return View(request);
            }
            if (request.NewImage.CheckFileSize(2000))
            {
                ModelState.AddModelError("NewImage", "Image size must be max 200KB");
                request.Image = adversiment.Image;
                return View(request);
            }

            await _adversitmentService.EditAsync(adversiment, request.NewImage);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _adversitmentService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
