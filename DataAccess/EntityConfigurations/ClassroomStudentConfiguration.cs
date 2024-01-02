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
    public class ClassroomStudentConfiguration : IEntityTypeConfiguration<ClassroomStudent>
    {
        public void Configure(EntityTypeBuilder<ClassroomStudent> builder)
        {
            builder.ToTable("ClassroomStudents").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.StudentId).HasColumnName("StudentId");
            builder.Property(b => b.ClassroomGroupId).HasColumnName("ClassroomGroupId");

            builder.HasOne(cs => cs.ClassroomGroup)
            .WithMany(cg => cg.ClassroomStudents)
            .HasForeignKey(cs => cs.ClassroomGroupId);

            builder.HasOne(cs => cs.Student)
            .WithMany(cg => cg.Classrooms)
            .HasForeignKey(cs => cs.StudentId);
                       



            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
