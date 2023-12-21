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
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.ToTable("Certificates").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId");
            builder.Property(b => b.Path).HasColumnName("Path");
            builder.Property(b => b.FileName).HasColumnName("FileName");

            builder.HasOne(b => b.User).WithMany(b => b.Certificates).HasForeignKey(b => b.UserId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
