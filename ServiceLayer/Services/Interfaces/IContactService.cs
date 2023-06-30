using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.ContactVM;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetAllAsync();
        Task<Contact> GetByIdAsync(int id);
        Task AddAsync(ContactAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int contactId, ContactEditVM model);
    }
}
