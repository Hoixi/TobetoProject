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
    public class CourseCompanyConfiguration : IEntityTypeConfiguration<CourseCompany>
    {
        public void Configure(EntityTypeBuilder<CourseCompany> builder)
        {
            builder.ToTable("CourseCompanies").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.CourseId).HasColumnName("CourseId");
            builder.Property(b => b.CompanyId).HasColumnName("CompanyId");

            builder.HasOne(b => b.Company)
            .WithMany(usm => usm.CourseCompanies)
            .HasForeignKey(usm => usm.CompanyId);

           

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
