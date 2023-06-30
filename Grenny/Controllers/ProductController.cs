using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.HomePageVM;
using ServiceLayer.ViewModels.Product;
using ServiceLayer.ViewModels.ProductPageVM;
using ServiceLayer.ViewModels.Social;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grenny.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISocialService _socialService;

        public ProductController(IProductService productService, ISocialService socialService)
        {
            _productService = productService;
            _socialService = socialService;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
                return BadRequest();

            var product = await _productService.GetByIdWithAllIncludesAsync(id.Value);
            var products = await _productService.GetAllWithIncludes();
            if (product == null)
                return NotFound();
            
            var productVM = await GetProductVM(product);

            var productPageVM = new ProductPageVM
            {
                ProductVM = productVM,
                SocialVM = await GetSocialVM()
            };
            var p = products.Where(m => m.CategoryId == product.CategoryId);
            ViewBag.viewProd = p;
            return View(productPageVM);
        }

        private async Task<ProductVM> GetProductVM(Product product)
        {
            List<string> images = product.Images.Select(image => image.Image).ToList();
            var tags = product.ProductTags.Select(m => m.Tag);

            var productVM = new ProductVM
            {
                Id = product.Id,
                Name = product.Name,
                Images = images,
                Discounts = product.Discount,
                Price = product.Price,
                Rating = product.Rating.RatingCount,
                Ratings = product.Rating,
                ReviewCount = product.Reviews.Count(),
                Desc = product.Description,
                SaleCount = product.SalesCount,
                SkuCode = product.SKUCode,
                Brand = product.Brand.Name,
                Tags = tags,
            };

            return productVM;
        }

        private async Task<IEnumerable<SocialVM>> GetSocialVM()
        {
            IEnumerable<Social> socials = await _socialService.GetAllAsync();

            List<SocialVM> socialViewModels = socials.Select(member => new SocialVM
            {
                Icon = member.Icon,
                Name = member.Name
            }).ToList();

            return socialViewModels;
        }
    }
}
