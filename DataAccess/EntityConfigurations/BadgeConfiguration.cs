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
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badges").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.ImageId).HasColumnName("ImageId");
            builder.Property(b => b.Name).HasColumnName("Name");
            


            builder.HasOne(a => a.Image)
            .WithMany(u => u.Badges)
            .HasForeignKey(u => u.ImageId);

            

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
