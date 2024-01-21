using Business.Dtos.Requests.UserRequests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RegisterValidator : AbstractValidator<UserForRegisterRequest>
    {
        public RegisterValidator()
        {
            RuleFor(i => i.Email).EmailAddress().WithMessage("E-posta düzgün girilmedi.");
            RuleFor(i => i.Password).MinimumLength(5).WithMessage("Şifre en az 5 haneli olmalıdır.");
        }
    }
}
