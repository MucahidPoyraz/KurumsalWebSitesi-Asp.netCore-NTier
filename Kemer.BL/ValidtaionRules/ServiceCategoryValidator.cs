using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class ServiceCategoryValidator : AbstractValidator<ServiceCategory>
    {
        public ServiceCategoryValidator()
        {
            RuleFor(ServiceCategory => ServiceCategory.ServiceCategoryName)
                .NotEmpty().WithMessage("Servis İsim alanı boş geçilemez!");




        }
    }
}
