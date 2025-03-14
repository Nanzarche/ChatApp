using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class ChatAppUnitOfWorks : IChatAppUnitOfWork , IDisposable
    {
        private readonly ChatAppContext _context;
        public ChatAppUnitOfWorks(ChatAppContext context)
        {
            _context = context;
        }

        public IBaseRepository<ChatUsers> ChatUsers { get { return new ChatAppBaseRepository<ChatUsers>(_context); } }
        public IBaseRepository<ChatRooms> ChatRooms { get { return new ChatAppBaseRepository<ChatRooms>(_context); } }
        public IBaseRepository<ChatMessages> ChatMessages { get { return new ChatAppBaseRepository<ChatMessages>(_context); } }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(_context != null)
                {
                    _context.Dispose();
                }                
            } 
        }
    }
}
