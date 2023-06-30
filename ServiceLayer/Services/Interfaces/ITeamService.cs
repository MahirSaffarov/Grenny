using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;
using ServiceLayer.ViewModels.AdminVM.TeamVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ITeamService
    {
        Task<IEnumerable<Team>> GetAllAsync();
        Task<Team> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task AddAsync(TeamAddVM model);
        Task EditAsync(int categoryId, TeamEditVM model);
    }
}
