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
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        public SubCategoryService(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public async Task<IEnumerable<SubCategory>> GetAllAsync()
        {
            return await _subCategoryRepository.GetAllAsync();
        }
    }
}
