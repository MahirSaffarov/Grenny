using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.ServiceVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class ServiceService : IServiceService
    {
        private IServiceRepository _serviceRepository;
        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task AddAsync(ServiceAddVM model)
        {
            Service service = new()
            {
                Text = model.Text,
                Title = model.Title,
            };

            await _serviceRepository.AddAsync(service);
        }

        public async Task DeleteAsync(int id)
        {
            var service = await _serviceRepository.GetByIdAsync(id);

            await _serviceRepository.DeleteAsync(service);
        }

        public async Task EditAsync(int serviceId, ServiceEditVM model)
        {
            var service = await _serviceRepository.GetByIdAsync(serviceId);

            service.Title = model.Title;
            service.Text = model.Text;

            await _serviceRepository.EditAsync(service);
        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            return await _serviceRepository.GetAllAsync();
        }

        public async Task<Service> GetByIdAsync(int id)
        {
            return await _serviceRepository.GetByIdAsync(id);
        }
    }
}
