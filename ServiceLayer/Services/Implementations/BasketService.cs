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
        private readonly IHttpContextAccessor _accessor;
        public BasketService(IBasketRepository basketRepository,
                             IHttpContextAccessor accessor)
        {
            _basketRepository = basketRepository;
            _accessor = accessor;
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
            _accessor.HttpContext.Response.Cookies.Append("basket", JsonSerializer.Serialize(basket));
            //var assd = _accessor.HttpContext.Response.Cookies["basket"];
            GetBasketDatas();
        }
        public List<BasketVM> GetBasketDatas()
        {
            List<BasketVM> basket = new List<BasketVM>();

            if (_accessor.HttpContext.User.Identity.IsAuthenticated)
            {
                string basketData = _accessor.HttpContext.Request.Cookies["basket"];

                if (!string.IsNullOrEmpty(basketData))
                {
                    basket = JsonSerializer.Deserialize<List<BasketVM>>(basketData);
                }
            }

            return basket;
        }


    }
}
