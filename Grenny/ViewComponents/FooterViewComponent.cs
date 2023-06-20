using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;

namespace Grenny.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly ILayoutService _layoutService;
        public FooterViewComponent(ILayoutService layoutService)
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
