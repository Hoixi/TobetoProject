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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.ImageId).HasColumnName("ImageId");
            builder.Property(b => b.Name).HasColumnName("Name");
            builder.Property(b => b.Description).HasColumnName("Description");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


            builder.HasMany(b => b.ClassroomGroupCourses)
            .WithOne(usm => usm.Courses)
            .HasForeignKey(usm => usm.CourseId);



            builder.HasOne(c => c.CourseSubType).WithMany(c => c.Courses).HasForeignKey(c => c.SubTypeId);

        }
    }
}
