using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Mapping
{
    public class ChatRoomsMap : IEntityTypeConfiguration<ChatRooms>
    {
        public void Configure(EntityTypeBuilder<ChatRooms> builder)
        {
            //Primary key
            builder.HasKey(x => x.Id);

            // Required 
            builder.Property(x => x.Id).IsRequired();

            // Table & Column Map
            builder.ToTable("TblChatRooms");
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.RoomName).HasColumnName("RoomName");
        }
    }
}
