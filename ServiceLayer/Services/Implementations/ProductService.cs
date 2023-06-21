using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            Expression<Func<Product, object>>[] includes =
            {
                entity => entity.SubCategory,
                entity => entity.Category,
                entity => entity.Discount,
                entity => entity.Brand,
                //entity => entity.BasketId,
                //entity => entity.WishlistId,
                entity => entity.Rating,
                entity => entity.Images.Where(m=>m.IsMain),
                entity => entity.Reviews,
                entity => entity.ProductTags
            };

            return await _productRepository.GetAllWithIncludes(includes);
        }
    }
}
