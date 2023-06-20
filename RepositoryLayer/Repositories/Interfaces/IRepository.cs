using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task SoftDeleteAsync(int? id);
        Task<T> GetByIdAsync(int? id);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>> expession = null);

    }
}
