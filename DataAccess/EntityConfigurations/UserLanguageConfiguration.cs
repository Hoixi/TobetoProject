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
    public class UserLanguageConfiguration : IEntityTypeConfiguration<UserLanguage>
    {
        public void Configure(EntityTypeBuilder<UserLanguage> builder)
        {
            builder.ToTable("UserLanguages").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.Property(b => b.LanguageId).HasColumnName("LanguageId");
            builder.Property(b => b.LanguageLevelId).HasColumnName("LanguageLevelId");
            builder.HasOne(b => b.User)
                .WithMany(b => b.UserLanguages)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(b => b.Language)
                .WithMany(b => b.UserLanguages)
                .HasForeignKey(b => b.LanguageId);

            builder.HasOne(b => b.LanguageLevel)
                .WithMany(b => b.UserLanguages)
                .HasForeignKey(b => b.LanguageLevelId);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
