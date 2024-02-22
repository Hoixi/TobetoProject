using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class UserBadgeConfiguration : IEntityTypeConfiguration<UserBadge>
    {
        public void Configure(EntityTypeBuilder<UserBadge> builder)
        {
            builder.ToTable("UserBadges").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.Property(b => b.BadgeId).HasColumnName("BadgeId");



            builder.HasOne(a => a.Badge)
            .WithMany(u => u.UserBadges)
            .HasForeignKey(u => u.BadgeId);

            builder.HasOne(a => a.User)
           .WithMany(u => u.UserBadges)
           .HasForeignKey(u => u.UserId);



            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
