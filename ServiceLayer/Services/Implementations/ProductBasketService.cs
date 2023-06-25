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

namespace ServiceLayer.Services.Implementations
{
    public class ProductBasketService : IProductBasketService
    {
        private readonly IProductBasketRepository _productBasketRepository;
        private readonly IBasketService _basketService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ProductBasketService(IProductBasketRepository productBasketRepository, 
                                    IBasketService basketService,
                                    IHttpContextAccessor httpContextAccessor)
        {
            _productBasketRepository = productBasketRepository;
            _basketService = basketService;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task AddProductToBasketAsync(List<ProductBasket> productBaskets)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var basket = await _basketService.GetBasketByUserId(userId);

            foreach (var productBasket in productBaskets)
            {
                if (productBasket.BasketId == basket.Id)
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
            }
        }

        public async Task<BasketVM> GetAllProductByBasket()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var basket = await _basketService.GetBasketByUserId(userId);   
            var basketProduct = await _productBasketRepository.GetByBasketIdAsync(basket.Id);

            BasketVM basketVM = new()
            {
                Id = basketProduct.ProductId,
                Count = basketProduct.ProductCount
            };

            return basketVM;
        }
    }
}
