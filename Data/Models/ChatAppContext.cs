using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public partial class ChatAppContext : DbContext
    {
        public ChatAppContext(DbContextOptions<ChatAppContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        // Entity 
        public DbSet<ChatUsers> ChatUsers { get; set; }
        public DbSet<ChatRooms> ChatRooms { get; set; }
        public DbSet<ChatMessages> ChatMessages { get; set; }
    }
}
