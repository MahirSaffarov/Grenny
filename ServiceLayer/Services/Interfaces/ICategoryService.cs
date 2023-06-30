using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.BrandVM;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<Category>> GetAllWithIncludes();
        Task<Category> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task AddAsync(CategoryAddVM model);
        Task EditAsync(int categoryId, CategoryEditVM model);
    }
}
