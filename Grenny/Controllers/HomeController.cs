
using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.Adversitment;
using ServiceLayer.ViewModels.BasketVM;
using ServiceLayer.ViewModels.Blog;
using ServiceLayer.ViewModels.Brand;
using ServiceLayer.ViewModels.Category;
using ServiceLayer.ViewModels.HomePageVM;
using ServiceLayer.ViewModels.Product;
using ServiceLayer.ViewModels.ShopPageVM;
using ServiceLayer.ViewModels.Slider;
using ServiceLayer.ViewModels.SliderInfo;
using System.Diagnostics;
using System.Text.Json;

namespace Grenny.Controllers
{
    public class HomeController : Controller
    { 
        private readonly IProductService _productService;
        private readonly ISliderService _sliderService;
        private readonly ISliderInfoService _sliderInfoService;
        private readonly ICategoryService _categoryService; 
        private readonly IAdversitmentService _adversitmentService;
        private readonly IBrandService _brandService;
        private readonly IBlogService _blogService;
        public HomeController(IProductService productService, 
                              ISliderService sliderService, 
                              ISliderInfoService sliderInfoService, 
                              ICategoryService categoryService, 
                              IAdversitmentService adversitmentService, 
                              IBrandService brandService, 
                              IBlogService blogService)
        {
            _productService = productService;
            _sliderService = sliderService;
            _sliderInfoService = sliderInfoService;
            _categoryService = categoryService;
            _adversitmentService = adversitmentService;
            _brandService = brandService;
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _productService.GetAllWithIncludes();

            var homePageVM = new HomePageVM
            {
                ProductVM = await GetProductVMs(),
                SliderVM = await GetSliderVMs(),
                SliderInfoVM = await GetSliderInfoVMs(),
                CategoryVM = await GetCategoryVMs(),
                AdversitmentVM = await GetAdversitmentVMs(),
                BrandVM = await GetBrandVMs(),
                BlogVM = await GetBlogVMs(),
            };

            return View(homePageVM);
        }

        private async Task<IEnumerable<ProductVM>> GetProductVMs()
        {
            var products = await _productService.GetAllWithIncludes();

            var productVM = new List<ProductVM>();

            var productViewModels = products.Select(member => new ProductVM
            {
                Id = member.Id,
                Name = member.Name,
                Image = member.Images.FirstOrDefault(m => m.IsMain).Image,
                Discounts = member.Discount,
                Price = member.Price,
                Rating = member.Rating.RatingCount,
                Ratings = member.Rating,
                ReviewCount = member.Reviews.Count()
            });

            return productViewModels;
        }

        private async Task<IEnumerable<SliderVM>> GetSliderVMs()
        {
            var sliders = await _sliderService.GetAllAsync();

            var sliderVM = new List<SliderVM>();

            var sliderViewModels = sliders.Select(member => new SliderVM
            {
                Image = member.Image
            });

            return sliderViewModels;
        }

        private async Task<IEnumerable<SliderInfoVM>> GetSliderInfoVMs()
        {
            var sliderInfos = await _sliderInfoService.GetAllAsync();

            var sliderInfoVM = new List<SliderInfoVM>();

            var sliderInfoViewModels = sliderInfos.Select(member => new SliderInfoVM
            {
                Text = member.Text,
                Title = member.Title
            });

            return sliderInfoViewModels;
        }

        private async Task<IEnumerable<CategoryVM>> GetCategoryVMs()
        {
            var categories = await _categoryService.GetAllWithIncludes();

            var categoryVM = new List<CategoryVM>();

            var categoryViewModels = categories.Select(member => new CategoryVM
            {
                Name = member.Name,
                ProductCount = member.Products.Count(),
                Image = member.Image
            });

            return categoryViewModels;
        }

        private async Task<IEnumerable<AdversitmentVM>> GetAdversitmentVMs()
        {
            var ads = await _adversitmentService.GetAllAsync();

            var adsVM = new List<AdversitmentVM>();

            var adsViewModels = ads.Select(member => new AdversitmentVM
            {
                Image = member.Image
            });

            return adsViewModels;
        }

        private async Task<IEnumerable<BrandVM>> GetBrandVMs()
        {
            var brands = await _brandService.GetAllWithIncludes();

            var brandVM = new List<BrandVM>();

            var blogViewModels = brands.Select(member => new BrandVM
            {
                Id = member.Id,
                Name = member.Name,
                ProductCount = member.Products.Count(),
            });

            return blogViewModels;
        }
        private async Task<IEnumerable<BlogVM>> GetBlogVMs()
        {
            var blogs = await _brandService.GetAllWithIncludes();

            var blogVM = new List<BlogVM>();

            var blogViewModels = blogs.Select(member => new BlogVM
            {
            });

            return blogViewModels;
        }
    }
}