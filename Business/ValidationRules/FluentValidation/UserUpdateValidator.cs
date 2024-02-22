using Business.Dtos.Requests.UserRequests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserUpdateValidator:AbstractValidator<UpdateUserRequest>
    {
        public UserUpdateValidator()
        {
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("Ad Uzunluğu 2 karakterden az olamaz");
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("Soyad Uzunluğu 2 karakterden az olamaz");
        }
    }
}
