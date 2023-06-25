using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IProductBasketRepository : IRepository<ProductBasket> 
    {
        Task<ProductBasket> GetByBasketIdAsync(int id);
    }
}
