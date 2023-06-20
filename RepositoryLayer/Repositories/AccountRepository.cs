using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DAL;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class AccountRepository : Repository<AppUser>, IAccountRepository
    {
        public AccountRepository(AppDbContext dbContext) : base(dbContext){ }
    }
}
