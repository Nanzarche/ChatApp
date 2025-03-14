using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Mapping
{
    public class ChatUsersMap : IEntityTypeConfiguration<ChatUsers>
    {
        public void Configure(EntityTypeBuilder<ChatUsers> builder)
        {
            // Primary Key
            builder.HasKey(x => x.Id);

            // Required
            builder.Property(x => x.Id).IsRequired();

            // Table and column Map
            builder.ToTable("TblChatUsers");
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.UserName).HasColumnName("UserName");
        }
    }
}
