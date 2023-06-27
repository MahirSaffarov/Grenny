using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.BasketVM;

namespace Grenny.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductBasketService _productBasketService;
        private readonly IBasketService _basketService;
        public ShopController(IProductService productService,
                              IProductBasketService productBasketService,
                              IBasketService basketService)
        {
            _productService = productService;
            _productBasketService = productBasketService;
            _basketService = basketService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBasket(int id)
        {
            var product = await _productService.GetByIdWithAllIncludesAsync(id);

            List<BasketVM> baskets = _basketService.GetBasketDatas();

            _basketService.AddProductToBasket(baskets, product);

            return RedirectToAction("Index","Home");
        }


    }
}
