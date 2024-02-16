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
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skills").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name");

            builder.HasMany(b => b.UserSkills)
                .WithOne(usm => usm.Skill)
                .HasForeignKey(usm => usm.SkillId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
