using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAdversitmentService
    {
        Task<IEnumerable<Adversiment>> GetAllAsync();
        Task<Adversiment> GetByIdAsync(int id);
        Task AddAsync(List<IFormFile> images);
        Task DeleteAsync(int id);
        Task EditAsync(Adversiment slider, IFormFile newImage);
    }
}
