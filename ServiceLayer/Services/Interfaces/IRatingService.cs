using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.RatingVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IRatingService
    {
        Task<IEnumerable<Rating>> GetAllAsync();
        Task<Rating> GetByIdAsync(int id);
        Task AddAsync(RatingAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int discountId, RatingEditVM model);
        Task<IEnumerable<Rating>> GetAllWithIncludes();
    }
}
