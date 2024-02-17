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
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.ToTable("Towns").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.CityId).HasColumnName("CityId");
            builder.Property(b => b.Name).HasColumnName("Name");

            builder.HasMany(b => b.Addresses)
            .WithOne(usm => usm.Town)
            .HasForeignKey(usm => usm.TownId);

            builder.HasOne(b => b.City)
            .WithMany(usm => usm.Towns)
            .HasForeignKey(usm => usm.CityId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
