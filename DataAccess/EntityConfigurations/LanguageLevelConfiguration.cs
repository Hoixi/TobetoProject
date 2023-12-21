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
    public class LanguageLevelConfiguration : IEntityTypeConfiguration<LanguageLevel>
    {
        public void Configure(EntityTypeBuilder<LanguageLevel> builder)
        {
            builder.ToTable("LanguageLevels").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name");
            builder.HasMany(b => b.UserLanguages)
                .WithOne(usm => usm.LanguageLevel)
                .HasForeignKey(usm => usm.LanguageLevelId);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
