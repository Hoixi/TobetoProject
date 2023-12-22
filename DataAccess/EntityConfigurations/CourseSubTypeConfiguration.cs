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
    public class CourseSubTypeConfiguration : IEntityTypeConfiguration<CourseSubType>
    {
        public void Configure(EntityTypeBuilder<CourseSubType> builder)
        {
            builder.ToTable("CourseSubTypes").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
            builder.HasMany(c => c.Courses).WithOne(c => c.CourseSubType).HasForeignKey(c => c.SubTypeId);
        }
    }
}
