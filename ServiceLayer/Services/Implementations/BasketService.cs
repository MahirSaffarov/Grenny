using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.BasketVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IProductBasketService _productBasketService;
        private readonly IHttpContextAccessor _accessor;
        public BasketService(IBasketRepository basketRepository,
                             IHttpContextAccessor accessor,
                             IProductBasketService productBasketService)
        {
            _basketRepository = basketRepository;
            _accessor = accessor;
            _productBasketService = productBasketService;
        }

        public async Task CreateAsync(AppUser user)
        {
            Basket basket = new();

            basket.AppUserId = user.Id;
            await _basketRepository.AddAsync(basket);

        }

        public async Task<Basket> GetBasketByUserId(string userId)
        {
            var baskets = await _basketRepository.FindByConditionAsync(m=>m.AppUserId==userId);
            var basket = baskets.FirstOrDefault();
            return basket;
        }
        public void AddProductToBasket(List<BasketVM> basket, Product product)
        {
            BasketVM existProduct = basket.FirstOrDefault(m => m.Id == product.Id);
            if (existProduct is null)
            {
                basket.Add(new BasketVM
                {
                    Id = product.Id,
                    Count = 1
                });
            }
            else
            {
                existProduct.Count++;
            }

            _accessor.HttpContext.Session.SetString("basket", JsonSerializer.Serialize(basket));
        }
        public List<BasketVM> GetBasketDatas()
        {
            List<BasketVM> basket;

            if (_accessor.HttpContext.Session.GetString("basket") != null)
            {
                basket = JsonSerializer.Deserialize<List<BasketVM>>(_accessor.HttpContext.Session.GetString("basket"));
            }
            else
            {
                basket = new List<BasketVM>();
            }

            return basket;
        }

        public  void GetBasketDatasAndSaveSession(ProductBasket productBasket)
        {
            var basketListVM =  _productBasketService.GetAllProductByBasket();

            _accessor.HttpContext.Session.SetString("basket", JsonSerializer.Serialize(basketListVM));
        }
    }
}
