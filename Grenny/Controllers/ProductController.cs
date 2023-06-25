using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;

namespace Grenny.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if(id is null) return BadRequest();

            IEnumerable<Product> products = await _productService.GetAllWithIncludes();

            if(products is null) return NotFound();

            AppUser user = new();

            //foreach (var product in products)
            //{
            //    ProductVM productVM = new()
            //    {
            //        Id = product.Id,
            //        Name = product.Name,
            //        SKUCode = product.SKUCode,
            //        Brand = product.Brand.Name,
            //        Rating = product.Rating.RatingCount,
            //        Reviews = product.Reviews.FirstOrDefault().Describe,
            //        ReviewCount = product.Reviews.Count(),
            //        ReviewCreateDate = product.CreateDate.ToString("dd/MMMM/yy"),
            //        Price = product.Price,
            //        Discount = product.Discount.Percent,
            //        Description = product.Description,
            //        //Tag = product.ProductTags.FirstOrDefault().Tag.Name,
            //        Images = product.Images,
            //        UserFullName = user.FullName
            //    };
            //}
            return View();
        }
    }
}
