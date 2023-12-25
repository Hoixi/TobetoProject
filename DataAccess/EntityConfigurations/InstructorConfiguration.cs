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
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.
                HasOne(b => b.User)
                .WithMany(b => b.Instructors)
                .HasForeignKey(b => b.UserId);

            builder.HasMany(b => b.CourseInstructors)
                .WithOne(b => b.Instructor)
                .HasForeignKey(b => b.InstructorId);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
            
        }
    }
}
