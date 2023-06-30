using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels;
using ServiceLayer.ViewModels.Adversitment;
using ServiceLayer.ViewModels.BasketVM;
using ServiceLayer.ViewModels.Blog;
using ServiceLayer.ViewModels.BlogPageVM;
using ServiceLayer.ViewModels.Brand;
using ServiceLayer.ViewModels.Category;
using ServiceLayer.ViewModels.Product;
using ServiceLayer.ViewModels.ShopPageVM;
using ServiceLayer.ViewModels.Tags;
using System.Linq;

namespace Grenny.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductBasketService _productBasketService;
        private readonly IBasketService _basketService;
        private readonly ITagService _tagService;
        private readonly IAdversitmentService _adversitmentService;
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IRatingService _ratingService;
        private readonly IBrandService _brandService;
        public ShopController(IProductService productService,
                              IProductBasketService productBasketService,
                              IBasketService basketService,
                              ITagService tagService,
                              IAdversitmentService adversitmentService,
                              IBlogService blogService,
                              ICategoryService categoryService,
                              IRatingService ratingService,
                              IBrandService brandService)
        {
            _productService = productService;
            _productBasketService = productBasketService;
            _basketService = basketService;
            _tagService = tagService;
            _adversitmentService = adversitmentService;
            _blogService = blogService;
            _categoryService = categoryService;
            _ratingService = ratingService;
            _brandService = brandService;
        }
        public async Task<IActionResult> Index(decimal? minPrice, decimal? maxPrice, int[] selectedRatings, string tagName)
        {
            var products = await _productService.GetAllWithIncludes();
            var shopPageVM = new ShopPageVM
            {
                ProductVM = await GetProductVMs(),
                AdversitmentVM = await GetAdversitmentVMs(),
                RatingVM = await GetRatingVMs(),
                TagVM = await GetTagVMs(),
                BrandVM = await GetBrandVMs(),
                CategoryVM = await GetCategoryVMs(),
            };

            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice.Value);
            }

            if (selectedRatings != null && selectedRatings.Length > 0)
            {
                products = products.Where(p => selectedRatings.Contains(p.Rating.Id));
            }

            if (!string.IsNullOrEmpty(tagName))
            {
                products = products.Where(p => p.ProductTags.Any(pt => pt.Tag.Name == tagName));
            }


            return View(shopPageVM);
        }
        [HttpPost]
        public async Task<IActionResult> AddBasket(int id)
        {
            var product = await _productService.GetByIdWithAllIncludesAsync(id);

            List<BasketVM> baskets = _basketService.GetBasketDatas();

            _basketService.AddProductToBasket(baskets, product);

            return RedirectToAction("Index","Home");
        }

        private async Task<IEnumerable<ProductVM>> GetProductVMs()
        {
            var products = await _productService.GetAllWithIncludes();

            var productVM = new List<ProductVM>();

            var productViewModels = products.Select(member => new ProductVM
            {
                Name = member.Name,
                Image = member.Images.FirstOrDefault(m=>m.IsMain).Image,
                Discounts = member.Discount,
                Price = member.Price,
                Rating = member.Rating.RatingCount,
                Ratings = member.Rating,
                ReviewCount = member.Reviews.Count(),

            });

            return productViewModels;
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

        private async Task<IEnumerable<RatingVM>> GetRatingVMs()
        {
            var ratings = await _ratingService.GetAllAsync();

            var ratingVMs = new List<RatingVM>();

            var ratingViewModels = ratings.Select(member => new RatingVM
            {
                RatingCount = member.RatingCount,
                ProductCount = member.Products.Count(),
            });

            return ratingViewModels;
        }

        private async Task<IEnumerable<TagVM>> GetTagVMs()
        {
            var tags = await _tagService.GetAllWithIncludes();

            var tagVMs = new List<TagVM>();

            var tagViewModels = tags.Select(member => new TagVM
            {
                Id = member.Id,
                Name = member.Name,
                ProductCount = member.ProductTags.GroupBy(pt => pt.ProductId).Count()
            });

            return tagViewModels;
        }
       
        private async Task<IEnumerable<BrandVM>> GetBrandVMs()
        {
            var brands = await _brandService.GetAllWithIncludes();

            var brandVM = new List<BrandVM>();

            var blogViewModels = brands.Select(member => new BrandVM
            {
                Id = member.Id,
                Name= member.Name,
                ProductCount = member.Products.Count(),
            });

            return blogViewModels;
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

            return categoryViewModels.Take(4);
        }


    }
}
