using Business.Dtos.Requests.UserRequests;
using Business.ValidationRules.FluentValidation;
using Castle.DynamicProxy;
using Core.Aspects;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace WebAPI.Utilities
{
    public static class ValidationAspectExtensions
    {
        public static IServiceCollection AddValidationAspect(this IServiceCollection services)
        {
            
                
            return services;
        }
    }
}
