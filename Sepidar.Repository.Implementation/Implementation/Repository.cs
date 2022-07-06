using Microsoft.EntityFrameworkCore;
using Sepidar.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DataContext Context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DataContext context)
        {
            this.Context = context;
            _dbSet = Context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await Context.Set<TEntity>().AddRangeAsync(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public async Task<ICollection<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public ValueTask<TEntity> GetByIdAsync(Guid id)
        {
            return Context.Set<TEntity>().FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefault(predicate);
        }

        public virtual IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> where)
        {
            IQueryable<TEntity> dbQuery = Context.Set<TEntity>();
            var query = dbQuery.Where(where);
            return query;
        }

        public virtual IQueryable<TEntity> OrderByDescending(Expression<Func<TEntity, object>> orderByDescending)
        {
            IQueryable<TEntity> dbQuery = Context.Set<TEntity>();
            var query = dbQuery.OrderByDescending(orderByDescending);
            return query;
        }

        public virtual IQueryable<TEntity> OrderBy(Expression<Func<TEntity, object>> orderBy)
        {
            IQueryable<TEntity> dbQuery = Context.Set<TEntity>();
            var query = dbQuery.OrderBy(orderBy);
            return query;
        }

        public IEnumerable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            return includeExpressions.Aggregate(_dbSet.AsQueryable(), (query, path) => query.Include(path));
        }

        public virtual bool Any(Expression<Func<TEntity, bool>> where)
        {
            IQueryable<TEntity> dbQuery = Context.Set<TEntity>();
            var query = dbQuery.Where(where).Any<TEntity>();
            return query;
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return Context.Set<TEntity>().AsQueryable();
        }
    }
}
