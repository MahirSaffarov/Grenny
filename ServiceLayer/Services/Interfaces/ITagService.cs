using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetAllAsync(); 
    }
}
