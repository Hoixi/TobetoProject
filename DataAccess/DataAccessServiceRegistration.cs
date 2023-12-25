using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TobetoContext>(options => options.UseSqlServer(configuration.GetConnectionString("Tobeto")));
        services.AddScoped<IAddressDal, EfAddressDal>();    
        services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();    
        services.AddScoped<ICategoryDal, EfCategoryDal>();    
        services.AddScoped<ICertificateDal, EfCertificateDal>();    
        services.AddScoped<ICityDal, EfCityDal>();    
        services.AddScoped<IClassroomDal, EfClassroomDal>();    
        services.AddScoped<IClassroomGroupCourseDal, EfClassroomGroupCourseDal>();    
        services.AddScoped<IClassroomGroupDal, EfClassroomGroupDal>();    
        services.AddScoped<ICourseInstructorDal, EfCourseInstructorDal>();    
        services.AddScoped<IClassroomStudentDal, EfClassroomStudentDal>();    
        services.AddScoped<ICompanyDal, EfCompanyDal>();    
        services.AddScoped<ICountryDal, EfCountryDal>();    
        services.AddScoped<ICourseCategoryDal, EfCourseCategoryDal>();    
        services.AddScoped<ICourseCompanyDal, EfCourseCompanyDal>();    
        services.AddScoped<ICourseDal, EfCourseDal>();    
        services.AddScoped<ICourseSubTypeDal, EfCourseSubTypeDal>();    
        services.AddScoped<IEducationDal, EfEducationDal>();    
        services.AddScoped<IEducationDegreeDal, EfEducationDegreeDal>();    
        services.AddScoped<IExperienceDal, EfExperienceDal>();    
        services.AddScoped<IGroupDal, EfGroupDal>();    
        services.AddScoped<IImageDal, EfImageDal>();    
        services.AddScoped<IInstructorDal, EfInstructorDal>();    
        services.AddScoped<ILanguageDal, EfLanguageDal>();    
        services.AddScoped<ILanguageLevelDal, EfLanguageLevelDal>();    
        services.AddScoped<IProgrammingLanguageDal, EfProgrammingLanguageDal>();    
        services.AddScoped<ISchoolNameDal, EfSchoolNameDal>();    
        services.AddScoped<ISkillDal, EfSkillDal>();    
        services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();    
        services.AddScoped<IStudentDal, EfStudentDal>();    
        services.AddScoped<ISurveyDal, EfSurveyDal>();    
        services.AddScoped<ITownDal, EfTownDal>();    
        services.AddScoped<IUserAnnouncementDal, EfUserAnnouncementDal>();    
        services.AddScoped<IUserDal, EfUserDal>();    
        services.AddScoped<IUserLanguageDal, EfUserLanguageDal>();    
        services.AddScoped<IUserSkillDal, EfUserSkillDal>();    
        services.AddScoped<IUserSocialMediaDal, EfUserSocialMediaDal>();    
        services.AddScoped<IUserSurveyDal, EfUserSurveyDal>();    


        return services;
    }
}
