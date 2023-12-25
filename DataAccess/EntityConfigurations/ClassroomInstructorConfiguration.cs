using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ClassroomInstructorConfiguration : IEntityTypeConfiguration<ClassroomInstructor>
{
    public void Configure(EntityTypeBuilder<ClassroomInstructor> builder)
    {
        builder.ToTable("ClassroomInstructors").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.InstructorId).HasColumnName("InstructorId");
        builder.Property(b => b.ClassroomId).HasColumnName("ClassroomId");
        builder.HasOne(b => b.Instructor)
        .WithMany(usm => usm.ClassroomInstructors)
        .HasForeignKey(usm => usm.InstructorId);
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
