using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IProductTagService
    {
        Task AddTagToProductAsync(Product product, int tagId);
        Task RemoveTagFromProductAsync(Product product, int tagId);
        Task<IEnumerable<ProductTag>> GetAllAsync();
        Task<IEnumerable<ProductTag>> GetTagsByProductIdAsync(int productId);
    }
}
    