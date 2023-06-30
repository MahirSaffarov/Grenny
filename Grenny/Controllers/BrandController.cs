using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.Blog;
using ServiceLayer.ViewModels.BrandPageVM;

namespace Grenny.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            var paginatedDatas = await _brandService.GetPaginatedDatasAsync(page, take);

            int pageCount = await GetCountAsync(take);

            if (page > pageCount)
            {
                return NotFound();
            }

            List<BrandPageVM> mappedDatas = _brandService.GetMappedDatas(paginatedDatas);

            Paginate<BrandPageVM> result = new(mappedDatas, page, pageCount);

            var brand = await _brandService.GetAllWithIncludes();

            return View(result);
        }
        private async Task<int> GetCountAsync(int take)
        {
            int count = await _brandService.GetCountAsync();

            var result = Math.Ceiling((decimal)count / take);

            return (int)result;
        }
    }
}
