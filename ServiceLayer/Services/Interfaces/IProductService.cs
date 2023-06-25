using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllWithIncludes();
        Task<Product> GetByIdWithAllIncludesAsync(int id);
        Task AddAsync(AddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int productId, EditVM model);
    }
}
