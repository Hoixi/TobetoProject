using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Messages;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCutingConcerns.Validations;

public class ValidationAttribute : Attribute
{
    public Type ValidatorType { get; }

    public ValidationAttribute(Type validatorType)
    {
        ValidatorType = validatorType;
    }

}