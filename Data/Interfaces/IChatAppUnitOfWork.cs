using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IChatAppUnitOfWork
    {
        void Commit();
        int Complete();
        IBaseRepository<ChatUsers> ChatUsers { get;}
        IBaseRepository<ChatRooms> ChatRooms { get; }
        IBaseRepository<ChatMessages> ChatMessages { get;}
    }
}
