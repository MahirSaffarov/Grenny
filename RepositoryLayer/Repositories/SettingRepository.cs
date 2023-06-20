using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DAL;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class SettingRepository : Repository<Setting>, ISettingRepository
    {
        public SettingRepository(AppDbContext dbContext) : base(dbContext){}
    }
}