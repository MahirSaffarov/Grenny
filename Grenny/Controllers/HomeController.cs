
using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.BasketVM;
using ServiceLayer.ViewModels.HomeVM;
using System.Diagnostics;
using System.Text.Json;

namespace Grenny.Controllers
{
    public class HomeController : Controller
    { 
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _productService.GetAllWithIncludes();
            
            HomeVM homeVM = new()
            {
                Products = products
            };

            return View(homeVM);
        }



        private async void GetBasketDatasAndSaveDataBase(ProductBasket productBasket)
        {
            List<BasketVM> basket = _basketService.GetBasketDatas();
            List<ProductBasket> listPivotBasket = new();

            ProductBasket pivotBasket = new()
            {
                ProductCount = productBasket.ProductCount,
                ProductId = productBasket.ProductId,
            };

            listPivotBasket.Add(pivotBasket);
            await _productBasketService.AddProductToBasketAsync(listPivotBasket);
        }


    }
}