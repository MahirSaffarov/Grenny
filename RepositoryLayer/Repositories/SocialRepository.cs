using DomainLayer.Entities;
using RepositoryLayer.DAL;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class SocialRepository : Repository<Social>, ISocialRepository
    {
        public SocialRepository(AppDbContext context) : base(context) { }
    }
}
