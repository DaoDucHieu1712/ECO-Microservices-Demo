using Contracts.Common;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class EntityRepository<T, K, TContext> : IEntityRepository<T, K, TContext>
    where T : BaseEntity<K>
    where TContext : DbContext
    {
        private readonly TContext _context;
        public EntityRepository(TContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> GetList(params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> items = _context.Set<T>();
                if (includeProperties != null)
                {
                    foreach (var includeProperty in includeProperties)
                    {
                        items = items.Include(includeProperty);
                    }
                }
                return await items.ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<List<T>> GetList(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {

            try
            {
                IQueryable<T> items = _context.Set<T>();
                if (includeProperties != null)
                {
                    foreach (var includeProperty in includeProperties)
                    {
                        items = items.Include(includeProperty);
                    }
                }
                return await items.Where(predicate).ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<T> FindById(K id, params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> items = _context.Set<T>();
                if (includeProperties != null)
                {
                    foreach (var includeProperty in includeProperties)
                    {
                        items = items.Include(includeProperty);
                    }
                }
                return await items.FirstOrDefaultAsync(x => x.Id.Equals(id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<T> FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> items = _context.Set<T>();
                if (includeProperties != null)
                {
                    foreach (var includeProperty in includeProperties)
                    {
                        items = items.Include(includeProperty);
                    }
                }
                return await items.SingleOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task Remove(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task Remove(K id)
        {
            try
            {
                var entity = FindById(id).Result;
                await Remove(entity);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task RemoveMultiple(List<T> entities)
        {
            try
            {
                _context.Set<T>().RemoveRange(entities);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task Update(T entity, params string[] propertiesToExclude)
        {
            try
            {
                _context.Set<T>().Attach(entity);
                var entry = _context.Entry(entity);
                entry.State = EntityState.Modified;
                foreach (var property in propertiesToExclude)
                {
                    entry.Property(property).IsModified = false;
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includes)
        {
            try
            {
                IQueryable<T> items = _context.Set<T>();
                if (includes != null)
                {
                    foreach (var includeProperty in includes)
                    {
                        items = items.Include(includeProperty);
                    }
                }
                return items;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            try
            {
                IQueryable<T> items = _context.Set<T>();
                if (includes != null)
                {
                    foreach (var includeProperty in includes)
                    {
                        items = items.Include(includeProperty);
                    }
                }
                return items.Where(predicate);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task AddMultiple(List<T> entities)
        {
            try
            {
                await _context.Set<T>().AddRangeAsync(entities);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<T> CreateAndGetEntity(T entity)
        {
            try
            {
                IQueryable<T> items = _context.Set<T>();
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return await items.FirstOrDefaultAsync(x => x.Id.Equals(entity.Id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
