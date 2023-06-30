using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;
        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public async Task<IActionResult> Index()
        {
            var discounts = await _discountService.GetAllAsync();

            List<DiscountVM> discountVM = new();

            foreach (var discount in discounts.OrderByDescending(m => m.Id))
            {
                discountVM.Add(new DiscountVM
                {
                    Id = discount.Id,
                    Name = discount.Name,
                    Percent = discount.Percent
                });
            }
            return View(discountVM);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var discount = await _discountService.GetByIdAsync((int)id);

            DiscountDetailVM details = new()
            {
                Name = discount.Name,
                Percent = discount.Percent,
                CreateDate = discount.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(DiscountAddVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _discountService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Discount discount = await _discountService.GetByIdAsync((int)id);

            if (discount == null) return NotFound();

            DiscountEditVM model = new()
            {
                Name = discount.Name,
                Percent = discount.Percent
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(DiscountEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var discount = await _discountService.GetByIdAsync((int)id);

            if (discount == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _discountService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();

            await _discountService.DeleteAsync((int)id);
            return Ok();
        }
    }
}
