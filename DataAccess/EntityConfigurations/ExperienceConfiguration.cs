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
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.ToTable("Experiences").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.Property(b => b.CityId).HasColumnName("CityId");
            builder.Property(b => b.CompanyName).HasColumnName("CompanyName");
            builder.Property(b => b.Position).HasColumnName("Position");
            builder.Property(b => b.Sector).HasColumnName("Sector");
            builder.Property(b => b.StartDate).HasColumnName("StartDate");
            builder.Property(b => b.EndDate).HasColumnName("EndDate");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
