using Data.Interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ChatAppBaseRepository<T> : IBaseRepository<T> where T : class 
    {
        private ChatAppContext _context;
        public ChatAppContext Context
        {
            get
            {
                return  _context;
            }
            set
            {
                _context = value;
            }
        }
        public ChatAppBaseRepository(ChatAppContext context)
        {
            _context = context;
        }
        public DbSet<T> DbSet { get; set; }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindBy (Expression<Func<T,bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        } 
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void UpdateRange(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
        }
         

    }
}
