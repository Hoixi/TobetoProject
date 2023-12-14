using Business.Abstracts;
using Business.Concretes;
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
        services.AddScoped<IRoleService,RoleManager>();
        services.AddScoped<ICourseService,CourseManager>();
        services.AddScoped<IUserService, UserManager>();
        services.AddScoped<IClassroomService, ClassroomManager>();
        services.AddScoped<IImageService, ImageManager>();
        services.AddScoped<IInstructorService, InstructorManager>();
        services.AddScoped<IStudentService, StudentManager>();
        services.AddScoped<IGroupService, GroupManager>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}
