using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using RepositoryLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq.Expressions;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using ServiceLayer.ViewModels.BasketVM;
using System.Text.Json;

namespace ServiceLayer.Services.Implementations
{
    public class ProductBasketService : IProductBasketService
    {
        private readonly IProductBasketRepository _productBasketRepository;
        private readonly IBasketService _basketService;
        private readonly IBasketRepository _basketRepository;
        private readonly IProductService _productService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ProductBasketService(IProductBasketRepository productBasketRepository, 
                                    IBasketService basketService,
                                    IHttpContextAccessor httpContextAccessor,
                                    IProductService productService,
                                    IBasketRepository basketRepository)
        {
            _productBasketRepository = productBasketRepository;
            _basketService = basketService;
            _httpContextAccessor = httpContextAccessor;
            _productService = productService;
            _basketRepository = basketRepository;
        }
        public async Task AddProductToBasketAsync(List<ProductBasket> productBaskets)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var basket = await _basketService.GetBasketByUserId(userId);

            foreach (var productBasket in productBaskets)
            {
                    var existingProductBasket = await _productBasketRepository
                    .GetByExpressionForPivotTable(pb => pb.BasketId == basket.Id && pb.ProductId == productBasket.ProductId);

                    if (existingProductBasket != null)
                    {
                        existingProductBasket.ProductCount = productBasket.ProductCount;
                    }
                    else
                    {
                        var newProductBasket = new ProductBasket
                        {
                            BasketId = basket.Id,
                            ProductId = productBasket.ProductId,
                            ProductCount = productBasket.ProductCount
                        };

                        await _productBasketRepository.AddAsync(newProductBasket);
                    }
            }
            _httpContextAccessor.HttpContext.Session.Remove("basket");

        }
        public async Task GetBasketDatasAndSaveDataBase(List<BasketVM> basketVM)
        {
            List<ProductBasket> listProductBaskets = new();

            foreach (var item in basketVM)
            {
                ProductBasket productBasket = new()
                {
                    ProductCount = item.Count,
                    ProductId = item.Id
                };

                listProductBaskets.Add(productBasket);

            }
            await AddProductToBasketAsync(listProductBaskets);
        }
        public async Task<List<BasketVM>> GetAllProductByBasket(string userId)
        {
            var basket = await _basketService.GetBasketByUserId(userId);
            var basketProduct = await _productBasketRepository.GetByBasketIdAsync(basket.Id);
            List<BasketVM> basketVMs = new();

            var basketProductCount = await _productBasketRepository.FindByConditionAsync(m => m.BasketId == basket.Id);
            for (int i = 0; i < basketProductCount.Count(); i++)
            {
                BasketVM basketVM = new()
                {
                    Id = basketProduct.ProductId,
                    Count = basketProduct.ProductCount
                };
                basketVMs.Add(basketVM);
            }

            return basketVMs;
        }
        public void GetBasketDatasAndSaveSession(string userId)
        {
            var basketListVM = GetAllProductByBasket(userId);

            _httpContextAccessor.HttpContext.Session.SetString("basket", JsonSerializer.Serialize(basketListVM));
        }
    }
}
