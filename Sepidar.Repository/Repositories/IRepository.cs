using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sepidar.Repository.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        Task<ICollection<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicat);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> where);
        IEnumerable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeExpressions);
        IQueryable<TEntity> OrderByDescending(Expression<Func<TEntity, object>> orderByDescending);
        IQueryable<TEntity> OrderBy(Expression<Func<TEntity, object>> orderBy);
        bool Any(Expression<Func<TEntity, bool>> where);
        IQueryable<TEntity> AsQueryable();
    }
}
