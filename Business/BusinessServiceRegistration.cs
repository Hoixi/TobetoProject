using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Business.Rules;
using Core.Utilities.Interceptors;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IAddressService, AddressManager>();
        services.AddScoped<IAnnouncementService, AnnouncementManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<ICertificateService, CertificateManager>();
        services.AddScoped<ICityService, CityManager>();
        services.AddScoped<IClassroomService, ClassroomManager>();
        services.AddScoped<IClassroomGroupCourseService, ClassroomGroupCourseManager>();
        services.AddScoped<IClassroomGroupService, ClassroomGroupManager>();
        services.AddScoped<ICourseInstructorService, CourseInstructorManager>();
        services.AddScoped<IClassroomStudentService, ClassroomStudentManager>();
        services.AddScoped<ICompanyService, CompanyManager>();
        services.AddScoped<ICountryService, CountryManager>();
        services.AddScoped<ICourseCategoryService, CourseCategoryManager>();
        services.AddScoped<ICourseCompanyService, CourseCompanyManager>();
        services.AddScoped<ICourseService, CourseManager>();
        services.AddScoped<ICourseSubTypeService, CourseSubTypeManager>();
        services.AddScoped<IEducationService, EducationManager>();
        services.AddScoped<IEducationDegreeService, EducationDegreeManager>();
        services.AddScoped<IExperienceService, ExperienceManager>();
        services.AddScoped<IGroupService, GroupManager>();
        services.AddScoped<IImageService, ImageManager>();
        services.AddScoped<IInstructorService, InstructorManager>();
        services.AddScoped<ILanguageService, LanguageManager>();
        services.AddScoped<ILanguageLevelService, LanguageLevelManager>();
        services.AddScoped<IProgrammingLanguageService, ProgrammingLanguageManager>();
        services.AddScoped<ISchoolNameService, SchoolNameManager>();
        services.AddScoped<ISkillService, SkillManager>();
        services.AddScoped<ISocialMediaService, SocialMediaManager>();
        services.AddScoped<IStudentService, StudentManager>();
        services.AddScoped<ISurveyService, SurveyManager>();
        services.AddScoped<ITownService, TownManager>();
        services.AddScoped<IUserAnnouncementService, UserAnnouncementManager>();
        services.AddScoped<IUserService, UserManager>();
        services.AddScoped<IUserLanguageService, UserLanguageManager>();
        services.AddScoped<IUserSkillService, UserSkillManager>();
        services.AddScoped<IUserSocialMediaService, UserSocialMediaManager>();
        services.AddScoped<IUserSurveyService, UserSurveyManager>();
      
        
        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));

        services.AddTransient(typeof(IService<>), typeof(ServiceProxy<>));

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }

    public static IServiceCollection AddSubClassesOfType(
       this IServiceCollection services,
       Assembly assembly,
       Type type,
       Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null
           )
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        foreach (var item in types)
            if (addWithLifeCycle == null)
                services.AddScoped(item);

            else
                addWithLifeCycle(services, type);
        return services;
    }


}
