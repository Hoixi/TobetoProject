using Core.CrossCutingConcerns.Exceptions.Types;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCutingConcerns.Validations;

public static class ValidationTool
{
    public static void Validate(IValidator validator, object entity)
    {

        ValidationContext<object> context = new(entity);
        ValidationResult result = validator.Validate(context);
        if (!result.IsValid) throw new ValidationCustomException(result.Errors);
    }
}