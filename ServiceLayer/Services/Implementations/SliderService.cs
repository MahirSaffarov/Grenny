using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IWebHostEnvironment _env;
        public SliderService(ISliderRepository sliderRepository,
                             IWebHostEnvironment env)
        {
            _sliderRepository = sliderRepository;
            _env = env;
        }

        public async Task<int> GetCountAsync()
        {
            var slider =  await _sliderRepository.FindByConditionAsync(m => m.Status);
            return slider.Count();
        }
        public async Task<bool> ChangeStatusAsync(Slider slider)
        {
            if (slider.Status && await GetCountAsync() != 1)
            {
                slider.Status = false;
            }
            else
            {
                slider.Status = true;
            }

            await _sliderRepository.EditAsync(slider);

            return slider.Status;
        }

        public async Task AddAsync(List<IFormFile> images)
        {
            foreach (var item in images)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + item.FileName;

                await item.SaveFileAsync(fileName, _env.WebRootPath, "images/slider");

                Slider slider = new()
                {
                    Image = fileName
                };

                await _sliderRepository.AddAsync(slider);
            }
        }

        public async Task DeleteAsync(int id)
        {
            Slider slider = await GetByIdAsync(id);

            _sliderRepository.DeleteAsync(slider);

            string path = Path.Combine(_env.WebRootPath, "images/slider", slider.Image);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

        public async Task EditAsync(Slider slider, IFormFile newImage)
        {
            string oldPath = Path.Combine(_env.WebRootPath, "images/slider", slider.Image);

            if (System.IO.File.Exists(oldPath))
            {
                System.IO.File.Delete(oldPath);
            }

            string fileName = Guid.NewGuid().ToString() + "_" + newImage.FileName;

            await newImage.SaveFileAsync(fileName, _env.WebRootPath, "images/slider");

            slider.Image = fileName;

            await _sliderRepository.EditAsync(slider);
        }

        public async Task<IEnumerable<Slider>> GetAllAsync()
        {
            return await _sliderRepository.GetAllAsync();
        }
            
        public async Task<Slider> GetByIdAsync(int id)
        {
            return await _sliderRepository.GetByIdAsync(id);
        }
    }
}
