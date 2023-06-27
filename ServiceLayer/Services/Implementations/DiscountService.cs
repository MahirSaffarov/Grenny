using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _discountRepository;
        public DiscountService(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task AddAsync(DiscountAddVM model)
        {
            Discount discount = new()
            {
                Name = model.Name,
                Percent = model.Percent
            };

            await _discountRepository.AddAsync(discount);
        }

        public async Task DeleteAsync(int id)
        {
            var discount = await _discountRepository.GetByIdAsync(id);

            await _discountRepository.DeleteAsync(discount);
        }

        public async Task EditAsync(int discountId, DiscountEditVM model)
        {
            var discount = await _discountRepository.GetByIdAsync(discountId);

            discount.Percent = model.Percent;
            discount.Name = model.Name;

            await _discountRepository.EditAsync(discount);
        }

        public async Task<IEnumerable<Discount>> GetAllAsync()
        {
            return await _discountRepository.GetAllAsync();
        }

        public Task<Discount> GetByIdAsync(int id)
        {
            return _discountRepository.GetByIdAsync(id);
        }
    }
}
