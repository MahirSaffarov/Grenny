using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.SubCategoryVM;
using ServiceLayer.ViewModels.AdminVM.TagVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetAllAsync();
        Task<Tag> GetByIdAsync(int id);
        Task AddAsync(TagAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int tagId, TagEditVM model);
        Task<IEnumerable<Tag>> GetAllWithIncludes();
    }
}
