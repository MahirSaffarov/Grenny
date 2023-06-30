using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.ContactVM;
using ServiceLayer.ViewModels.AdminVM.ServiceVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IServiceService
    {
        Task<IEnumerable<Service>> GetAllAsync();
        Task<Service> GetByIdAsync(int id);
        Task AddAsync(ServiceAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int serviceId, ServiceEditVM model);
    }
}
