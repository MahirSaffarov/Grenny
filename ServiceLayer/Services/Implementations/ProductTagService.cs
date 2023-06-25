using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class ProductTagService : IProductTagService
    {
        private readonly IProductTagRepository _productTagRepository;

        public ProductTagService(IProductTagRepository productTagRepository)
        {
            _productTagRepository = productTagRepository;
        }

        public async Task AddTagToProductAsync(Product product, int tagId)
        {
            ProductTag productTag = new ProductTag
            {
                ProductId = product.Id,
                TagId = tagId
            };

            await _productTagRepository.AddAsync(productTag);
        }

        public async Task RemoveTagFromProductAsync(Product product, int tagId)
        {
            IEnumerable<ProductTag> productTags = await _productTagRepository.FindByConditionAsync(pt => pt.ProductId == product.Id && pt.TagId == tagId);

            foreach (ProductTag productTag in productTags)
            {
                await _productTagRepository.DeleteAsync(productTag);
            }
        }

        public async Task<IEnumerable<ProductTag>> GetAllAsync()
        {
            return await _productTagRepository.GetAllAsync();
        }
        public async Task<IEnumerable<ProductTag>> GetTagsByProductIdAsync(int productId)
        {
            return await _productTagRepository.FindByConditionAsync(pt => pt.ProductId == productId);
        }
    }
}
