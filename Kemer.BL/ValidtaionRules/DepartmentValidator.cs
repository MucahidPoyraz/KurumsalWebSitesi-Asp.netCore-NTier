using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(Department => Department.DepartmanName)
        .NotEmpty().WithMessage("Departman alanı boş geçilemez!");


        }
    }
}
