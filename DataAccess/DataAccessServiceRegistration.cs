using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TobetoContext>(options => options.UseSqlServer(configuration.GetConnectionString("Tobeto")));
        services.AddScoped<ICourseDal, EfCourseDal>();
        services.AddScoped<IRoleDal, EfRoleDal>();
        services.AddScoped<IUserDal, EfUserDal>();
        services.AddScoped<IClassroomDal, EfClassroomDal>();
        services.AddScoped<IImageDal, EfImageDal>();
        return services;
    }
}
