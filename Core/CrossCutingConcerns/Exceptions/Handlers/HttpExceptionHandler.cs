using Core.CrossCutingConcerns.Exceptions.Extensions;
using Core.CrossCutingConcerns.Exceptions.HttpProblemDetails;
using Core.CrossCutingConcerns.Exceptions.Types;
using Core.CrossCutingConcerns.HttpProblemDetails;
using Core.CrossCutingConcerns.Types;
using Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.CrossCutingConcerns.Handlers;

public class HttpExceptionHandler : ExceptionHandler
{
    private HttpResponse? _response;
    private readonly ValidationProblem _validationProblem;
    public HttpExceptionHandler()
    {
        _validationProblem = new ValidationProblem();
    }
    public HttpResponse Response
    {
        get => _response ?? throw new ArgumentNullException(nameof(_response));
        set => _response = value;
    }

    protected override Task HandleException(BusinessException businessException)
    {       
        Response.StatusCode = StatusCodes.Status400BadRequest;     
        string details = new BusinessProblemDetails(businessException.Message).AsJson();
        return Response.WriteAsync(details);
    }

    protected override Task HandleException(ValidationCustomException validationException)
    {
        Response.Headers.Add("Access-Control-Allow-Origin", "*");
        Response.StatusCode = StatusCodes.Status400BadRequest;
        string details = _validationProblem.Result(validationException).AsJson();
        return Response.WriteAsync(details);
    }

    //protected override Task HandleException(Exception exception)
    //{
    //    Response.StatusCode = StatusCodes.Status500InternalServerError;
    //    string details = new InternalServerErrorProblemDetails(exception.Message).AsJson();
    //    return Response.WriteAsync(details);
    //}

}
