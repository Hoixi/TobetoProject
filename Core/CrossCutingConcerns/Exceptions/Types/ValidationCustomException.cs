using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCutingConcerns.Exceptions.Types
{
    public class ValidationCustomException : ValidationException
    {
        public ValidationCustomException(IEnumerable<ValidationFailure> errors) : base(errors) { }
    }
}
