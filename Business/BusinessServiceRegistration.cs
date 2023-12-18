using Business.Abstracts;
using Business.Concretes;
using Core.Business.Rules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        //services.AddScoped<IRoleService,RoleManager>();
        services.AddScoped<ICourseService,CourseManager>();
        services.AddScoped<IUserService, UserManager>();
        services.AddScoped<IClassroomService, ClassroomManager>();
        services.AddScoped<IImageService, ImageManager>();
        services.AddScoped<IInstructorService, InstructorManager>();
        services.AddScoped<IStudentService, StudentManager>();
        services.AddScoped<IGroupService, GroupManager>();
        //services.AddScoped<IClassroomGroupCourseService, ClasroomGroupCourseManager>();


        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));


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
