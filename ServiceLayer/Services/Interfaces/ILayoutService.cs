using ServiceLayer.ViewModels;

namespace ServiceLayer.Services.Interfaces
{
    public interface ILayoutService
    {
        Task<LayoutVM> GetLayoutData();
    }
}
