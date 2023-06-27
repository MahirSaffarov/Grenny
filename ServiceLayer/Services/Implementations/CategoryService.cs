using DomainLayer.Entities;
using Grenny.Helpers;
using Microsoft.AspNetCore.Hosting;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.BrandVM;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IcategoryRepository _categoryRepository;
        private readonly IWebHostEnvironment _env;

        public CategoryService(IcategoryRepository categoryRepository,
                               IWebHostEnvironment env)
        {
            _categoryRepository = categoryRepository;
            _env = env;
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            await _categoryRepository.DeleteAsync(category);

            string directoryPath = Path.Combine(_env.WebRootPath, "images/category", category.Image);

            if (System.IO.File.Exists(directoryPath))
            {
                System.IO.File.Delete(directoryPath);
            }
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }
        public async Task<Category> GetByIdAsync(int id)
        {
             return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(CategoryAddVM model)
        {

            string fileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
            await model.Image.SaveFileAsync(fileName, _env.WebRootPath, "images/category");

            Category category = new()
            {
                Name = model.Name,
                Image = fileName
            };

            await _categoryRepository.AddAsync(category);

        }

        public async Task EditAsync(int categoryId, CategoryEditVM model)
        {
            var category = await _categoryRepository.GetByIdAsync(categoryId);

            if (model.NewImage != null)
            {
                string oldPath = Path.Combine(_env.WebRootPath, "images/category", category.Image);

                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                string fileName = Guid.NewGuid().ToString() + "_" + model.NewImage.FileName;
                await model.NewImage.SaveFileAsync(fileName, _env.WebRootPath, "images/category");

                category.Image = fileName;
            }

            category.Name = model.Name;

            await _categoryRepository.EditAsync(category);
        }
    }
}
