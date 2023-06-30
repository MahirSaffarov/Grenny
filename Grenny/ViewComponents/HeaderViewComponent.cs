using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.BlogPageVM;
using ServiceLayer.ViewModels.Category;
using ServiceLayer.ViewModels.HeaderPageVM;
using ServiceLayer.ViewModels.Subcategory;

namespace Grenny.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ILayoutService _layoutService;
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;
        public HeaderViewComponent(ILayoutService layoutService, ICategoryService categoryService, ISubCategoryService subCategoryService)
        {
            _layoutService = layoutService;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = await _layoutService.GetLayoutData();

            var headerPageVM = new HeaderPageVM
            {
                Data = datas,
                CategoryVM = await GetCategoryVMs(),
                SubcategoryVM = await GetSubCatogVMs()
            };
            
            return await Task.FromResult(View(headerPageVM));
        }

        private async Task<IEnumerable<CategoryVM>> GetCategoryVMs()
        {
            var categories = await _categoryService.GetAllWithIncludes();

            var category = new List<CategoryVM>();

            var categoryViewModels = categories.Select(member => new CategoryVM
            {
                Id = member.Id,
                Name = member.Name,
                ProductCount = member.Products.Count,
            });

            return categoryViewModels;
        }

        private async Task<IEnumerable<SubcategoryVM>> GetSubCatogVMs()
        {
            var subcategories = await _subCategoryService.GetAllWithIncludes();

            var subcategory = new List<SubcategoryVM>();

            var subCategoryViewModels = subcategories.Select(member => new SubcategoryVM
            {
                CategoryId = member.CategoryId,
                Name = member.Name
            });

            return subCategoryViewModels;
        }
    }
}
