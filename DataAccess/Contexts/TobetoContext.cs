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

    public DbSet<Address> Addresses{ get; set; }
    public DbSet<Certificate> Certificates{ get; set; }
    public DbSet<City> Cities{ get; set; }
    public DbSet<Classroom> Classrooms{ get; set; }
    public DbSet<ClassroomGroup> ClassroomGroups{ get; set; }
    public DbSet<ClassroomGroupCourse> ClassroomGroupCourses{ get; set; }
    public DbSet<ClassroomInstructor> ClassroomInstructors { get; set; }
    public DbSet<ClassroomStudent> ClassroomStudents { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<EducationsDegree> EducationsDegree { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<LanguageLevel> LanguageLevels { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Town> Towns { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserCertificate> UserCertificates { get; set; }
    public DbSet<UserLanguage> UserLanguages { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<UserSocialMedia> UserSocialMedias { get; set; }
    
    


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
