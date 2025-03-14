using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Mapping
{
    public class ChatMessagesMap: IEntityTypeConfiguration<ChatMessages>
    {
        public void Configure(EntityTypeBuilder<ChatMessages> builder)
        {
            // Primary Key
            builder.HasKey(x => x.Id);

            // Required
            builder.Property(x => x.Id).IsRequired();

            //Table and Column map
            builder.ToTable("");
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.UserId).HasColumnName("UserId");
            builder.Property(x => x.RoomId).HasColumnName("RoomId");
            builder.Property(x => x.MessgeText).HasColumnName("MessageText");
            builder.Property(x => x.Timestamp).HasColumnName("Timestamp");

        }
    }
}
