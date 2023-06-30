using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.ContactVM;
using ServiceLayer.ViewModels.AdminVM.ServiceVM;
using Microsoft.AspNetCore.Authorization;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _contactService.GetAllAsync();

            List<ContactVM> contactVM = new();

            foreach (var service in contacts.OrderByDescending(m => m.Id))
            {
                contactVM.Add(new ContactVM
                {
                    Id = service.Id,
                    Text = service.Text,
                    Title = service.Title
                });
            }
            return View(contactVM);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var contact = await _contactService.GetByIdAsync((int)id);

            ContactDetailVM details = new()
            {
                Text = contact.Text,
                Title = contact.Title,
                CreateDate = contact.CreateDate.ToString("dd/MMMM/yyyy")
            };

            return View(details);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ContactAddVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _contactService.AddAsync(request);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Contact contact = await _contactService.GetByIdAsync((int)id);

            if (contact == null) return NotFound();

            ContactEditVM model = new()
            {
                Title = contact.Title,
                Text = contact.Text
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ContactEditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            var contact = await _contactService.GetByIdAsync((int)id);

            if (contact == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _contactService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();

            await _contactService.DeleteAsync((int)id);
            return Ok();
        }
    }
}
