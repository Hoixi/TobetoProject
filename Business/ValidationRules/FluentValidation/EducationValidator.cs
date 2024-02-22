using Business.Dtos.Requests.EducationRequests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EducationValidator:AbstractValidator<CreateEducationRequest>
    {
        public EducationValidator()
        {
            RuleFor(e => e.EducationDegreeId).GreaterThan(0).WithMessage("Boş bırakılamaz");
            RuleFor(e => e.StartDate).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(e => e.SchoolNameId).GreaterThan(0).WithMessage("Boş bırakılamaz");
            RuleFor(e => e.Department).NotEmpty().WithMessage("Boş bırakılamaz");
        }
    }
}
