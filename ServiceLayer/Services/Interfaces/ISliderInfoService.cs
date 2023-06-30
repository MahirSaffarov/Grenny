using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.SliderInfoVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderInfoService
    {
        Task CreateAsync(SliderInfoCreateVM sliderInfoCreate);
        Task DeleteAsync(int id);
        Task EditAsync(SliderInfo slidersInfo, SliderInfoEditVM request);
        Task<SliderInfo> GetByIdAsync(int id);
        Task<IEnumerable<SliderInfo>> GetAllAsync();
    }
}
