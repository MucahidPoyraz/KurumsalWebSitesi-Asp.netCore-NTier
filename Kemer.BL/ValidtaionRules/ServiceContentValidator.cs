using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class ServiceContentValidator : AbstractValidator<ServiceContent>
    {
        public ServiceContentValidator()
        {


            RuleFor(ServiceContent => ServiceContent.Header)
                .NotEmpty().WithMessage("Başlik alanı boş geçilemez!")
                .Length(5, 50).WithMessage("Başlik alanı 5 ile 50 karakter arasında olmalıdır!"); ;

            RuleFor(ServiceContent => ServiceContent.Content)
                .NotEmpty().WithMessage("İçerik Soyisim alanı boş geçilemez!")
                .Length(5, 200).WithMessage("İçerik alanı 5 ile 200 karakter arasında olmalıdır!"); ;

            RuleFor(ServiceContent => ServiceContent.ServiceId)
                .NotEmpty().WithMessage("Servis alanı boş geçilemez!");

        }
    }
}
