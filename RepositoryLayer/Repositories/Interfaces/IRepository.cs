using Microsoft.EntityFrameworkCore.Query;
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
        Task AddRangeAsync(IEnumerable<T> entities);
        Task EditAsync(T entity);
        Task DeleteAsync(T entity);
        Task SoftDeleteAsync(int? id);
        Task<T> GetByIdAsync(int? id);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>> expession = null);
        Task<IEnumerable<T>> GetAllWithIncludesAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includeFuncs);
        Task<T> GetByIdWithAllIncludesAsync(int id, Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includeFuncs);
        Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByExpressionForPivotTable(Expression<Func<T, bool>> expression);
    }
}
