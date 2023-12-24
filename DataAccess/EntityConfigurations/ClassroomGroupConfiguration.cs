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
    public class ClassroomGroupConfiguration : IEntityTypeConfiguration<ClassroomGroup>
    {
        public void Configure(EntityTypeBuilder<ClassroomGroup> builder)
        {
            builder.ToTable("ClassroomGroups").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.ClassroomId).HasColumnName("ClassroomId");
            builder.Property(b => b.GroupId).HasColumnName("GroupId");



            builder.HasOne(b => b.Group)
          .WithMany(usm => usm.ClassroomGroups)
          .HasForeignKey(usm => usm.GroupId);

            builder.HasOne(b => b.Classroom)
           .WithMany(usm => usm.ClassroomGroups)
           .HasForeignKey(usm => usm.ClassroomId);



            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
