using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using RepositoryLayer.DAL;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<T> GetByExpressionForPivotTable(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }


        public async Task EditAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SoftDeleteAsync(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            T entity = await _dbSet.FindAsync(id) ?? throw new NullReferenceException("Data not found.");

            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            T entity = await _dbSet.FindAsync(id);

            return entity ?? throw new NullReferenceException("Data not found.");
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            IQueryable<T> query = _dbSet;
            if (expression != null)
            {
                query = query.Where(expression);
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllWithIncludesAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includeFuncs)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            foreach (var includeFunc in includeFuncs)
            {
                query = includeFunc(query);
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetByIdWithAllIncludesAsync(int id, Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includeFuncs)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            foreach (var includeFunc in includeFuncs)
            {
                query = includeFunc(query);
            }


            return await query.FirstOrDefaultAsync(m => EF.Property<int>(m, "Id") == id);
        }
    }
}
