using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class UserAnnouncementConfiguration : IEntityTypeConfiguration<UserAnnouncement>
{
    public void Configure(EntityTypeBuilder<UserAnnouncement> builder)
    {
        builder.ToTable("UserAnnouncements").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.UserId).HasColumnName("UserId");
        builder.Property(b => b.AnnouncementId).HasColumnName("AnnouncementId");
        builder.HasOne(b => b.User).WithMany(b => b.UserAnnouncements).HasForeignKey(b => b.UserId);

        builder.HasOne(b => b.Announcement)
                .WithMany(b => b.UserAnnouncements)
                .HasForeignKey(b => b.AnnouncementId);




        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        
    }
}
