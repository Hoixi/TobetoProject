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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.Property(b => b.StudentNumber).HasColumnName("StudentNumber");

            builder.HasMany(b => b.Classrooms)
            .WithOne(usm => usm.Student)
            .HasForeignKey(usm => usm.StudentId);

            builder.HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.UserId);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
