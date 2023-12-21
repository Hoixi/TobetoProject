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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.ImageId).HasColumnName("ImageId");
            builder.Property(b => b.NationalIdentity).HasColumnName("NationalIdentity");
            builder.Property(b => b.FirstName).HasColumnName("FirstName");
            builder.Property(b => b.LastName).HasColumnName("LastName");
            builder.Property(b => b.PhoneNumber).HasColumnName("PhoneNumber");
            builder.Property(b => b.Email).HasColumnName("Email");
            builder.Property(b => b.BirthDate).HasColumnName("BirthDate");
            builder.Property(b => b.Password).HasColumnName("Password");

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
