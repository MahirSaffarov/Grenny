using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
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

        public async Task<Dictionary<string, string>> GetAllSettings()
        {
            var settings = await _settingRepository.GetAllAsync();
            var settingDictionary = settings.ToDictionary(m => m.Key, m => m.Value);
            return settingDictionary;
        }
    }
}