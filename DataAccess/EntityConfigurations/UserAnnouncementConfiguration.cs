using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class UserAnnouncementConfiguration : IEntityTypeConfiguration<UserAnnouncement>
    {
        public void Configure(EntityTypeBuilder<UserAnnouncement> builder)
        {
            builder.ToTable("UserAnnouncements").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.Property(b => b.AnnouncementId).HasColumnName("AnnouncementId");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
