using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.City;
using ServiceLayer.ViewModels.Contact;
using ServiceLayer.ViewModels.ContactPageVM;
using ServiceLayer.ViewModels.HomePageVM;

namespace Grenny.Controllers
{
    public class ContactController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IContactService _contactService;
        public ContactController(ICityService cityService, IContactService contactService)
        {
            _cityService = cityService;
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var contactPageVM = new ContactPageVM
            {
                ContactVM = await GetContactVMs(),
                CityVM = await GetCityVMs()
            };

            return View(contactPageVM);
        }

        private async Task<IEnumerable<CityVM>> GetCityVMs()
        {
            var cities = await _cityService.GetAllAsync();

            var cityVM = new List<CityVM>();

            var cityViewModels = cities.Select(member => new CityVM
            {
                Image = member.Image,
                Text = member.Name,
                Title = member.Address
            });

            return cityViewModels;
        }

        private async Task<IEnumerable<ContactVM>> GetContactVMs()
        {
            var contacts = await _contactService.GetAllAsync();

            var contactVM = new List<ContactVM>();

            var contactViewModels = contacts.Select(member => new ContactVM
            {
                Title = member.Title,
                Text = member.Text
            });

            return contactViewModels;
        }
    }
}
