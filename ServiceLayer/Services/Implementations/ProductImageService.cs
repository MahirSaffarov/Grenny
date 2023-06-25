using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class ProductImageService : IProductImageService
    {
        private readonly IProductImageRepository _productImageRepository;

        public ProductImageService(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }

        public async Task AddRangeAsync(IEnumerable<ProductImage> model)
        {
            await _productImageRepository.AddRangeAsync(model);
        }
    }
}
