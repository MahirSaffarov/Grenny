﻿using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.BrandVM;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using ServiceLayer.ViewModels.BrandPageVM;
using ServiceLayer.Helpers;

namespace ServiceLayer.Services.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IWebHostEnvironment _env;

        public BrandService(IBrandRepository brandRepository,
                            IWebHostEnvironment env)
        {
            _brandRepository = brandRepository;
            _env = env;
        }
        public Task<IEnumerable<Brand>> GetAllAsync()
        {
            return _brandRepository.GetAllAsync();
        }

        public async Task<Brand> GetByIdAsync(int id)
        {
            return await _brandRepository.GetByIdAsync(id); 
        }

        public async Task AddAsync(BrandAddVM model)
        {

            string fileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
            await model.Image.SaveFileAsync(fileName, _env.WebRootPath, "images/brand");

            Brand brand = new()
            {
                Name = model.Name,
                Image = fileName
            };

            await _brandRepository.AddAsync(brand);

        }

        public async Task DeleteAsync(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);

            await _brandRepository.DeleteAsync(brand);

            string directoryPath = Path.Combine(_env.WebRootPath, "images/brand", brand.Image);

            if (System.IO.File.Exists(directoryPath))
            {
                System.IO.File.Delete(directoryPath);
            }

        }

        public async Task EditAsync(int brandId, BrandEditVM model)
        {
            var brand = await _brandRepository.GetByIdAsync(brandId);

            if (model.NewImage != null)
            {
                string oldPath = Path.Combine(_env.WebRootPath, "images/brand", brand.Image);

                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                string fileName = Guid.NewGuid().ToString() + "_" + model.NewImage.FileName;
                await model.NewImage.SaveFileAsync(fileName, _env.WebRootPath, "images/brand");

                brand.Image = fileName;
            }

            brand.Name = model.Name;

            await _brandRepository.EditAsync(brand);
        }

        public async Task<IEnumerable<Brand>> GetAllWithIncludes()
        {
            Func<IQueryable<Brand>, IIncludableQueryable<Brand, object>>[] includeFuncs =
            {
                entity => entity.Include(m=>m.Products),
            };

            return await _brandRepository.GetAllWithIncludesAsync(includeFuncs);
        }

        public async Task<List<Brand>> GetPaginatedDatasAsync(int page, int take)
        {
            var allDatas = await GetAllWithIncludes();
            return allDatas.Skip((page - 1) * take).Take(take).ToList();
        }
        public List<BrandPageVM> GetMappedDatas(List<Brand> brands)
        {
            List<BrandPageVM> list = new();
            foreach (var brand in brands)
            {
                list.Add(new BrandPageVM
                {
                    Name = brand.Name,
                    Image = brand.Image,
                    ProductCount = brand.Products.Count(),
                });
            }
            return list;
        }

        public async Task<int> GetCountAsync()
        {
            var brands = await _brandRepository.GetAllAsync();
            return brands.Count();
        }
    }
}
