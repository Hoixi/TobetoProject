using Core.Entities;
using Core.Entities.Concretes;

namespace Entities.Concretes;

public class User : Entity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public string? NationalIdentity { get; set; }   
    public string? PhoneNumber { get; set; }    
    public int? ImageId { get; set; }
    public DateTime? BirthDate { get; set; }
    public List<UserSocialMedia> UserSocialMedias { get; set; }
    public List<UserLanguage> UserLanguages { get; set; }
    public List<Certificate> Certificates { get; set; }
    public List<UserAnnouncement> UserAnnouncements { get; set; }
    public List<Experience> Experiences { get; set; }
    public List<UserSurvey> UserSurveys { get; set; }
    public List<Address> Addresses { get; set; }
    public List<Instructor> Instructors { get; set; }
}

