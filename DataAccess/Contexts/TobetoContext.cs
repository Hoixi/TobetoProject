using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts;

public class TobetoContext : DbContext
{
    protected IConfiguration Configuration { get; set; }

    public DbSet<Address> Addresses{ get; set; }/**/
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Certificate> Certificates{ get; set; }
    public DbSet<City> Cities{ get; set; }
    public DbSet<Classroom> Classrooms{ get; set; }
    public DbSet<ClassroomGroup> ClassroomGroups{ get; set; }
    public DbSet<ClassroomGroupCourse> ClassroomGroupCourses{ get; set; }
    public DbSet<ClassroomInstructor> ClassroomInstructors { get; set; }
    public DbSet<ClassroomStudent> ClassroomStudents { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseCategory> CourseCategories { get; set; }
    public DbSet<CourseCompany> CourseCompanies { get; set; }
    public DbSet<CourseSubType> CourseSubTypes { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<EducationDegree> EducationsDegree { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<LanguageLevel> LanguageLevels { get; set; }
    public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
    public DbSet<SchoolName> SchoolNames { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Town> Towns { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserLanguage> UserLanguages { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<UserSocialMedia> UserSocialMedias { get; set; }
    public DbSet<UserAnnouncement> UserAnnouncements { get; set; }
    public DbSet<UserSurvey> UserSurveys { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Survey> Surveys { get; set; }




    public TobetoContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
        //Database.EnsureCreated(); 
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
