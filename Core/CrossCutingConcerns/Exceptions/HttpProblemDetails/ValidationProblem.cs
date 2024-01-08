using Core.CrossCutingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCutingConcerns.Exceptions.HttpProblemDetails;

public class ValidationProblem
{
    public ValidationProblemDetails Result(ValidationCustomException validationException)
    {
        var validationProblemDetails = new ValidationProblemDetails
        {
            Type = "https://www.example.com/validation-error",
            Title = "Validation error occurred.",
            Status = StatusCodes.Status400BadRequest,          
        };

        foreach (var error in validationException.Errors)
        {
            var key = string.IsNullOrEmpty(error.PropertyName) ? "General" : error.PropertyName;

            // Eğer Errors içinde key zaten varsa, listeye ekleyin; yoksa yeni bir liste oluşturun.
            if (validationProblemDetails.Errors.TryGetValue(key, out var existingErrors))
            {
                existingErrors = (string[])existingErrors.Concat(new[] { error.ErrorMessage });
                validationProblemDetails.Errors[key] = existingErrors.ToArray();
            }
            else
            {
                validationProblemDetails.Errors[key] = new[] { error.ErrorMessage };
            }
        }
        return validationProblemDetails;
    }
}
