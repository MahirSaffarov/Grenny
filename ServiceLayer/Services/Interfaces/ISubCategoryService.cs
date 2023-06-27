using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using ServiceLayer.ViewModels.AdminVM.SubCategoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISubCategoryService
    {
        Task AddAsync(SubCategoryAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int productId, SubCategoryEditVM model);
        Task<IEnumerable<SubCategory>> GetAllWithIncludes();
        Task<SubCategory> GetByIdWithAllIncludesAsync(int id);

    }
}
