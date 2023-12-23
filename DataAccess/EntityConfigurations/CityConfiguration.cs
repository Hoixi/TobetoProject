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
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name");
            builder.HasMany(b => b.Experiences).WithOne(b => b.City).HasForeignKey(b => b.CityId);

            builder.HasMany(b => b.Addresses)
            .WithOne(usm => usm.City)
            .HasForeignKey(usm => usm.CityId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
