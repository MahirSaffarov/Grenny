using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.SocialVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISocialService
    {
        Task<IEnumerable<Social>> GetAllAsync();
        Task<Social> GetByIdAsync(int id);
        Task AddAsync(SocialAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int socialId, SocialEditVM model);
    }
}
