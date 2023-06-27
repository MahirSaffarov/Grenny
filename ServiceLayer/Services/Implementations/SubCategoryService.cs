using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using ServiceLayer.ViewModels.AdminVM.SubCategoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        public SubCategoryService(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public async Task AddAsync(SubCategoryAddVM model)
        {
            SubCategory subCategory = new()
            {
                Name = model.Name,
                CategoryId = model.CategoryId
            };

            await _subCategoryRepository.AddAsync(subCategory);
        }

        public async Task DeleteAsync(int id)
        {
            var subCategory = await _subCategoryRepository.GetByIdAsync(id);

            await _subCategoryRepository.DeleteAsync(subCategory);
        }

        public async Task EditAsync(int productId, SubCategoryEditVM model)
        {
            var subCategory = await _subCategoryRepository.GetByIdAsync(productId);

            subCategory.CategoryId = model.CategoryId;
            subCategory.Name = model.Name;

            await _subCategoryRepository.EditAsync(subCategory);
        }

        public async Task<IEnumerable<SubCategory>> GetAllWithIncludes()
        {
            Func<IQueryable<SubCategory>, IIncludableQueryable<SubCategory, object>>[] includeFuncs =
            {
                entity => entity.Include(m=>m.Category),
            };

            return await _subCategoryRepository.GetAllWithIncludesAsync(includeFuncs);
        }

        public async Task<SubCategory> GetByIdWithAllIncludesAsync(int id)
        {
            Func<IQueryable<SubCategory>, IIncludableQueryable<SubCategory, object>>[] includeFuncs =
            {
                entity => entity.Include(m=>m.Category),
            };

            return await _subCategoryRepository.GetByIdWithAllIncludesAsync(id, includeFuncs);
        }
    }
}
