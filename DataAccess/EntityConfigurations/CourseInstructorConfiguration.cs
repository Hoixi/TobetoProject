using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CourseInstructorConfiguration : IEntityTypeConfiguration<CourseInstructor>
{
    public void Configure(EntityTypeBuilder<CourseInstructor> builder)
    {
        builder.ToTable("CourseInstructors").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.InstructorId).HasColumnName("InstructorId");
        builder.Property(b => b.CourseId).HasColumnName("CourseId");

        builder.HasOne(b => b.Instructor)
        .WithMany(usm => usm.CourseInstructors)
        .HasForeignKey(usm => usm.InstructorId);

        builder.HasOne(b => b.Instructor)
        .WithMany(usm => usm.CourseInstructors)
        .HasForeignKey(usm => usm.InstructorId);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
