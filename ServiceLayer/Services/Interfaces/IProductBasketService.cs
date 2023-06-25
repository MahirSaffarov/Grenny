using DomainLayer.Entities;
using ServiceLayer.ViewModels.BasketVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IProductBasketService
    {
        Task AddProductToBasketAsync(List<ProductBasket> productBaskets);
        Task<BasketVM> GetAllProductByBasket();
    }
}
