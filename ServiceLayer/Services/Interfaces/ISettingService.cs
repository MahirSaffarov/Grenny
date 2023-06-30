using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.SettingVM;
using System.Collections.Generic;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISettingService
    {
        Task<Dictionary<string, string>> GetAllSettings();
        Task<IEnumerable<Setting>> GetAllSettingsWithIdAsync();
        Task<Setting> GetByIdAsync(int id);
        Task AddAsync(SettingAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int settingId, SettingEditVM model);
    }
}