using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.ServiceVM;
using Microsoft.AspNetCore.Authorization;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public async Task<IActionResult> Index()
        {
            var services = await _serviceService.GetAllAsync();

            List<ServiceVM> serviceVM = new();

            foreach (var service in services.OrderByDescending(m => m.Id))
            {
                serviceVM.Add(new ServiceVM
                {
                    Id = service.Id,
                    Text = service.Text,
                    Title = service.Title
                });
            }
            return View(serviceVM);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var service = await _serviceService.GetByIdAsync((int)id);

            ServiceDetailVM details = new()
            {
                Text = service.Text,
                Title = service.Title,
                CreateDate = service.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ServiceAddVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _serviceService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Service service = await _serviceService.GetByIdAsync((int)id);

            if (service == null) return NotFound();

            ServiceEditVM model = new()
            {
                Title = service.Title,
                Text = service.Text
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ServiceEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var service = await _serviceService.GetByIdAsync((int)id);

            if (service == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _serviceService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();

            await _serviceService.DeleteAsync((int)id);
            return Ok();
        }
    }
}
