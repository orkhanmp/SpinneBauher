using Core.Abstract;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class BaseRepository<T, TContext> : IBaseRepository<T>
        where T : BaseEntity, new()
        where TContext : DbContext
    {

        protected readonly TContext _context;
        public BaseRepository(TContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            
                var entityAdded = _context.Entry(entity);
                entityAdded.State = EntityState.Added;
                _context.SaveChanges();
            
        }

        public void Delete(T entity)
        {
           
                var entityDelete = _context.Entry(entity);
                entityDelete.State = EntityState.Deleted;
                _context.SaveChanges();
            
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
           
                return _context.Set<T>().FirstOrDefault(predicate);
            
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            
                return predicate is null
                    ? _context.Set<T>().ToList()
                    : _context.Set<T>().Where(predicate).ToList();
            
        }

        public void Update(T entity)
        {
            
                var entityUpdate = _context.Entry(entity);
                entityUpdate.State = EntityState.Modified;
                _context.SaveChanges();
            
        }
    }
}
