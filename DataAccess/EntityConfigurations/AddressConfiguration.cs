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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.Property(b => b.TownId).HasColumnName("TownId");
            builder.Property(b => b.CityId).HasColumnName("CityId");
            builder.Property(b => b.CountryId).HasColumnName("CountryId");
            builder.Property(b => b.Description).HasColumnName("Description");

            builder.HasOne(a => a.User)
            .WithMany(u => u.Addresses)
            .HasForeignKey(u => u.UserId);

            builder.HasOne(a => a.City)
            .WithMany(u => u.Addresses)
            .HasForeignKey(u => u.CityId);

            builder.HasOne(a => a.Country)
            .WithMany(u => u.Addresses)
            .HasForeignKey(u => u.CountryId);

            builder.HasOne(a => a.Town)
            .WithMany(u => u.Addresses)
            .HasForeignKey(u => u.TownId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
