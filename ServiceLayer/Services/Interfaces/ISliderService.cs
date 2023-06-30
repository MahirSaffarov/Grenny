using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> GetAllAsync();
        Task<Slider> GetByIdAsync(int id);
        Task<bool> ChangeStatusAsync(Slider slider);
        Task AddAsync(List<IFormFile> images);
        Task DeleteAsync(int id);
        Task EditAsync(Slider slider, IFormFile newImage);
    }
}
