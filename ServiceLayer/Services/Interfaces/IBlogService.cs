using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.BlogVM;
using ServiceLayer.ViewModels.AdminVM.SubCategoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBlogService
    {
        Task AddAsync(BlogAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int blogId, BlogEditVM model);
        Task<IEnumerable<Blog>> GetAllWithIncludes();
        Task<Blog> GetByIdWithAllIncludesAsync(int id);

    }
}
