using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {


            RuleFor(Service => Service.HeaderOne)
                .NotEmpty().WithMessage("Bu Başlik alanı boş geçilemez!");

            RuleFor(Service => Service.SubtitleOne)
                .NotEmpty().WithMessage("Bu içerik alanı boş geçilemez!");

            RuleFor(Service => Service.ServiceCategoryID)
                .NotEmpty().WithMessage("Kategori alanı boş geçilemez!");

        }
    }
}
