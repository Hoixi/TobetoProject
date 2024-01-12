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
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Educations").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.Property(b => b.EducationDegreeId).HasColumnName("EducationDegreeId");
            builder.Property(b => b.SchoolNameId).HasColumnName("SchoolNameId");
            builder.Property(b => b.Department).HasColumnName("Department");
            builder.Property(b => b.StartDate).HasColumnName("StartDate");
            builder.Property(b => b.EndDate).HasColumnName("EndDate");

            builder.HasOne(usm => usm.User)
           .WithMany(u => u.Educations)
           .HasForeignKey(usm => usm.UserId);

            builder.HasOne(b => b.EducationDegree)
                .WithMany(b => b.Educations)
                .HasForeignKey(b => b.EducationDegreeId);

            builder.HasOne(b => b.SchoolName)
                .WithMany(b => b.Educations)
                .HasForeignKey(b => b.SchoolNameId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
