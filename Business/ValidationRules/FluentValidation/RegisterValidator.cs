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
            //RuleFor(i => i.Password).Matches(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-_]).{8,15}$").WithMessage("Şifre en az 5 haneli olmalıdır.");
        }
    }
}
