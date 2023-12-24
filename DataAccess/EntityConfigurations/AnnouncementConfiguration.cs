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
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.ToTable("Announcements").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name");
            builder.Property(b => b.Description).HasColumnName("Description");


            builder.HasMany(b => b.UserAnnouncements)
            .WithOne(usm => usm.Announcement)
            .HasForeignKey(usm => usm.Id);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
