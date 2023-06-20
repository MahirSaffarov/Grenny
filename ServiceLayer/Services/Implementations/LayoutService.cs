using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels;

namespace ServiceLayer.Services.Implementations
{
    public class LayoutService : ILayoutService
    {
        private readonly ISettingService _settingService;

        public LayoutService(ISettingService settingService)
        {
            _settingService = settingService;
        }

        public async Task<LayoutVM> GetLayoutData()
        {
            var settingsData = await _settingService.GetAllSettings();

            var layoutVM = new LayoutVM
            {
                SettingsData = settingsData
            };

            return layoutVM;
        }
    }
}