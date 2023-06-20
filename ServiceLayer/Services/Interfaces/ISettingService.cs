using System.Collections.Generic;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISettingService
    {
        Task<Dictionary<string, string>> GetAllSettings();
    }
}