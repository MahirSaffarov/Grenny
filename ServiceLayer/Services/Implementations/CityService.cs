using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;
using ServiceLayer.ViewModels.AdminVM.CityVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IWebHostEnvironment _env;
        public CityService(ICityRepository cityRepository,
                           IWebHostEnvironment env)
        {
            _cityRepository = cityRepository;
            _env = env;
        }
        public async Task AddAsync(CityAddVM model)
        {
            string fileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
            await model.Image.SaveFileAsync(fileName, _env.WebRootPath, "images/city");

            City city = new()
            {
                Name = model.Name,
                Address = model.Address,
                Image = fileName
            };

            await _cityRepository.AddAsync(city);

        }

        public async Task DeleteAsync(int id)
        {
            var city = await _cityRepository.GetByIdAsync(id);

            await _cityRepository.DeleteAsync(city);

            string directoryPath = Path.Combine(_env.WebRootPath, "images/city", city.Image);

            if (System.IO.File.Exists(directoryPath))
            {
                System.IO.File.Delete(directoryPath);
            }
        }

        public async Task EditAsync(int cityId, CityEditVM model)
        {
            var city = await _cityRepository.GetByIdAsync(cityId);

            if (model.NewImage != null)
            {
                string oldPath = Path.Combine(_env.WebRootPath, "images/city", city.Image);

                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                string fileName = Guid.NewGuid().ToString() + "_" + model.NewImage.FileName;
                await model.NewImage.SaveFileAsync(fileName, _env.WebRootPath, "images/city");

                city.Image = fileName;
            }

            city.Name = model.Name;
            city.Address = model.Address;

            await _cityRepository.EditAsync(city);
        }

        public async Task<IEnumerable<City>> GetAllAsync()
        {
            return await _cityRepository.GetAllAsync();
        }

        public async Task<City> GetByIdAsync(int id)
        {
            return await _cityRepository.GetByIdAsync(id);
        }
    }
}
