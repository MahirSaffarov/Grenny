using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DAL;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class ProductBasketRepository : Repository<ProductBasket>, IProductBasketRepository
    {
        public ProductBasketRepository(AppDbContext context) : base(context) { }
        public async Task<ProductBasket> GetByBasketIdAsync(int id)
        {
            return await _dbContext.ProductBaskets.FirstOrDefaultAsync(m => m.BasketId == id);
        }
    }
}
