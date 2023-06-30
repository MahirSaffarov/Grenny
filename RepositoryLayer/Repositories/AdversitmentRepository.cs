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
    public class AdversitmentRepository : Repository<Adversiment>, IAdversitmentRepository
    {
        public AdversitmentRepository(AppDbContext context) : base(context) { }
    }
}
