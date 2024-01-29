using Castle.DynamicProxy;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCutingConcerns.Validations;

public class ValidationMiddleware
{
    private readonly RequestDelegate _next;

    public ValidationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext, IServiceProvider serviceProvider)
    {
        var endpoint = httpContext.Features.Get<IEndpointFeature>()?.Endpoint;
        var attribute = endpoint?.Metadata.GetMetadata<ValidationAttribute>();
        
        if (endpoint != null)
        {
            var validator = (IValidator)Activator.CreateInstance(attribute.ValidatorType);
            var entityType = attribute.ValidatorType.BaseType.GetGenericArguments()[0];
            var requestBody =  await GetRequestBody(httpContext.Request);
            var model = JsonConvert.DeserializeObject(requestBody, entityType);
            ValidationTool.Validate(validator, model);
            
        }

        await _next(httpContext);
    }

    private async Task<string> GetRequestBody(HttpRequest request)
    {
        if(request.ContentLength == 0 || request.Body == null || !request.Body.CanRead)
        {
            return null;
        }

        request.EnableBuffering();
        var body = await new StreamReader(request.Body).ReadToEndAsync();
        request.Body.Seek(0, SeekOrigin.Begin);
        return body;
    }
}
