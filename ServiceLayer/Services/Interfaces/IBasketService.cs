using DomainLayer.Entities;
using ServiceLayer.ViewModels.BasketVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBasketService
    {
        Task CreateAsync(AppUser user);
        Task<Basket> GetBasketByUserId(string userId);
        void AddProductToBasket(List<BasketVM> basket, Product product);
        List<BasketVM> GetBasketDatas();
    }
}
