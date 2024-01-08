using Business.Dtos.Requests.UserRequests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation;

public class UserValidate : AbstractValidator<CreateUserRequest>
{
    public UserValidate()
    {
        RuleFor(u => u.NationalIdentity).Length(11);
        RuleFor(u => u.Email).EmailAddress();
    }
}
