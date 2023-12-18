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
    public class ClassroomInstructorConfiguration : IEntityTypeConfiguration<ClassroomInstructor>
    {
        public void Configure(EntityTypeBuilder<ClassroomInstructor> builder)
        {
            builder.ToTable("ClassroomInstructors").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.InstructorId).HasColumnName("InstructorId");
            builder.Property(b => b.ClassroomId).HasColumnName("ClassroomId");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
