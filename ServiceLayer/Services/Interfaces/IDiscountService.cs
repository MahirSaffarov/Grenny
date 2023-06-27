using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.BrandVM;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<IEnumerable<Discount>> GetAllAsync();
        Task<Discount> GetByIdAsync(int id);
        Task AddAsync(DiscountAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int discountId, DiscountEditVM model);
    }
}
