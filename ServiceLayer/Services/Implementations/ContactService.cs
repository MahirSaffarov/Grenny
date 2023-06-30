using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.ContactVM;
using ServiceLayer.ViewModels.AdminVM.ServiceVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public async Task AddAsync(ContactAddVM model)
        {
            Contact contact = new()
            {
                Text = model.Text,
                Title = model.Title
            };

            await _contactRepository.AddAsync(contact);
        }

        public async Task DeleteAsync(int id)
        {
            var service = await _contactRepository.GetByIdAsync(id);

            await _contactRepository.DeleteAsync(service);
        }

        public async Task EditAsync(int contactId, ContactEditVM model)
        {
            var service = await _contactRepository.GetByIdAsync(contactId);

            service.Title = model.Title;
            service.Text = model.Text;

            await _contactRepository.EditAsync(service);
        }

        public async Task<IEnumerable<Contact>> GetAllAsync()
        {
            return await _contactRepository.GetAllAsync();
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
            return await _contactRepository.GetByIdAsync(id);
        }
    }
}
