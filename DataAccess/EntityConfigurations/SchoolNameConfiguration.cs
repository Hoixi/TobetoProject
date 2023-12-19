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
    public class SchoolNameConfiguration : IEntityTypeConfiguration<SchoolName>
    {
        public void Configure(EntityTypeBuilder<SchoolName> builder)
        {
            builder.ToTable("SchoolNames").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
