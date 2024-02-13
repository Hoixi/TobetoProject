using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

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
        builder.Property(b => b.Description).HasColumnName("Description");
        builder.Property(b => b.BirthDate).HasColumnName("BirthDate");
        builder.Property(b => b.PasswordHash).HasColumnName("PasswordHash");
        builder.Property(b => b.PasswordSalt).HasColumnName("PasswordSalt");
        
    builder.HasMany(b => b.UserSocialMedias)
        .WithOne(usm => usm.User) // UserSocialMedia sınıfındaki User ilişkisi
        .HasForeignKey(usm => usm.UserId);

        builder.HasMany(b => b.UserLanguages)
        .WithOne(usm => usm.User)
        .HasForeignKey(usm => usm.UserId);

        builder.HasMany(b => b.Certificates)
        .WithOne(usm => usm.User)
        .HasForeignKey(usm => usm.UserId);

        builder.HasMany(b => b.UserAnnouncements)
        .WithOne(usm => usm.User)
        .HasForeignKey(usm => usm.UserId);

        builder.HasMany(b => b.Experiences)
        .WithOne(usm => usm.User)
        .HasForeignKey(usm => usm.UserId);

        builder.HasMany(b => b.UserSurveys)
        .WithOne(usm => usm.User)
        .HasForeignKey(usm => usm.UserId);

        builder.HasMany(b => b.Addresses)
        .WithOne(usm => usm.User)
        .HasForeignKey(usm => usm.UserId);

        builder.HasMany(b => b.Instructors)
        .WithOne(usm => usm.User)
        .HasForeignKey(usm => usm.UserId);

        builder.HasMany(b => b.Educations)
        .WithOne(usm => usm.User)
        .HasForeignKey(usm => usm.UserId);


        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
