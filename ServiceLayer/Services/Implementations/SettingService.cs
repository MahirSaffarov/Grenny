using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.SettingVM;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Services.Implementations
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository _settingRepository;

        public SettingService(ISettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
        }

        public async Task AddAsync(SettingAddVM model)
        {
            Setting setting = new()
            {
                Key = model.Key,
                Value = model.Value
            };

            await _settingRepository.AddAsync(setting);
        }

        public async Task DeleteAsync(int id)
        {
            var discount = await _settingRepository.GetByIdAsync(id);

            await _settingRepository.DeleteAsync(discount);
        }

        public async Task EditAsync(int settingId, SettingEditVM model)
        {
            var setting = await _settingRepository.GetByIdAsync(settingId);

            setting.Key = model.Key;
            setting.Value = model.Value;

            await _settingRepository.EditAsync(setting);
        }

        public async Task<Dictionary<string, string>> GetAllSettings()
        {
            var settings = await _settingRepository.GetAllAsync();
            var settingDictionary = settings.ToDictionary(m => m.Key, m => m.Value);
            return settingDictionary;
        }

        public Task<IEnumerable<Setting>> GetAllSettingsWithIdAsync()
        {
            return _settingRepository.GetAllAsync();
        }

        public Task<Setting> GetByIdAsync(int id)
        {
            return _settingRepository.GetByIdAsync(id);
        }
    }
}