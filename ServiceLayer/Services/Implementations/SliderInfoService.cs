using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.SliderInfoVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class SliderInfoService : ISliderInfoService
    {
        private readonly ISliderInfoRepository _sliderInfoRepository;
        public SliderInfoService(ISliderInfoRepository sliderInfoRepository)
        {
            _sliderInfoRepository = sliderInfoRepository;
        }

        public async Task CreateAsync(SliderInfoCreateVM sliderInfoCreate)
        {
            SliderInfo slidersInfo = new()
            {
                Title = sliderInfoCreate.Title,
                Text = sliderInfoCreate.Text,
            };

            await _sliderInfoRepository.AddAsync(slidersInfo);
        }

        public async Task DeleteAsync(int id)
        {
            SliderInfo slidersInfo = await GetByIdAsync(id);

            _sliderInfoRepository.DeleteAsync(slidersInfo);
        }

        public async Task EditAsync(SliderInfo slidersInfo, SliderInfoEditVM request)
        {
            slidersInfo.Text = request.Text;
            slidersInfo.Title = request.Title;


            await _sliderInfoRepository.EditAsync(slidersInfo);
        }

        public async Task<IEnumerable<SliderInfo>> GetAllAsync()
        {
            return await _sliderInfoRepository.GetAllAsync();
        }

        public async Task<SliderInfo> GetByIdAsync(int id)
        {
            return await _sliderInfoRepository.GetByIdAsync(id);
        }
    }
}
