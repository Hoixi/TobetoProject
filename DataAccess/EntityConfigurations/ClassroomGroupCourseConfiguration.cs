using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ClassroomGroupCourseConfiguration : IEntityTypeConfiguration<ClassroomGroupCourse>
{
    public void Configure(EntityTypeBuilder<ClassroomGroupCourse> builder)
    {
        builder.ToTable("ClassroomGroupCourses").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.ClassroomGroupId).HasColumnName("ClassroomGroupId");
        builder.Property(b => b.CourseId).HasColumnName("CourseId");


        builder.HasOne(b => b.ClassroomGroups)
        .WithMany(usm => usm.ClassroomGroupCourses)
        .HasForeignKey(usm => usm.ClassroomGroupId);



        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
