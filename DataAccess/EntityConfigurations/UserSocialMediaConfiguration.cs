using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations;

public class UserSocialMediaConfiguration : IEntityTypeConfiguration<UserSocialMedia>
{
    public void Configure(EntityTypeBuilder<UserSocialMedia> builder)
    {
        builder.ToTable("UserSocialMedias").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.UserId).HasColumnName("UserId");
        builder.Property(b => b.SocialMediaId).HasColumnName("SocialMediaId");
        builder.HasOne(usm => usm.User)
           .WithMany(u => u.UserSocialMedias) 
           .HasForeignKey(usm => usm.UserId);

        builder.HasOne(usm => usm.SocialMedia)
           .WithMany(u => u.userSocialMedias)
           .HasForeignKey(usm => usm.SocialMediaId);
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
