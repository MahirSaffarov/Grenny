using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;

namespace Grenny.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ILayoutService _layoutService;
        public HeaderViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = await _layoutService.GetLayoutData();
            return await Task.FromResult(View(datas));
        }
    }
}
