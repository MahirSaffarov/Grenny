using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DAL;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(AppDbContext context) : base(context) { }
    }
}
