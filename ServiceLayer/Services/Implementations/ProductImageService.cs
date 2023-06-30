using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment _env;

        public ProductImageService(IProductImageRepository productImageRepository,
                                   IWebHostEnvironment env)
        {
            _productImageRepository = productImageRepository;
            _env = env;
        }

        public async Task AddRangeAsync(IEnumerable<ProductImage> model)
        {
            await _productImageRepository.AddRangeAsync(model);
        }

        public async Task DeleteAsync(ProductImage image)
        {
            await _productImageRepository.DeleteAsync(image);
        }

        public async Task EditAsync(ProductImage image)
        {
             await _productImageRepository.EditAsync(image);
        }

        public async Task<IEnumerable<ProductImage>> GetAllAsync()
        {
            return await _productImageRepository.GetAllAsync();
        }

        public async Task<ProductImage> GetByIdAsync(int id)
        {
            return await _productImageRepository.GetByIdAsync(id);
        }
    }
}
