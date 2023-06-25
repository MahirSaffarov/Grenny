using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DAL;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class BasketRepository : Repository<Basket>, IBasketRepository
    {
        public BasketRepository(AppDbContext dbContext) : base(dbContext){ }
    }
}
