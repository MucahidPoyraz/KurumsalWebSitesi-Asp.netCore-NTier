using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class WhoWeAreValidator : AbstractValidator<WhoWeAre>
    {
        public WhoWeAreValidator()
        {

            RuleFor(WhoWeAre => WhoWeAre.Header)
                .NotEmpty().WithMessage("Başlik alanı boş geçilemez!")
                .Length(5, 50).WithMessage("Visyon alanı 5 ile 50 karakter arasında olmalıdır!");

            RuleFor(WhoWeAre => WhoWeAre.Content)
                .NotEmpty().WithMessage("İçerik alanı boş geçilemez!")
                .Length(5, 200).WithMessage("İçerik alanı 5 ile 200 karakter arasında olmalıdır!");
        }
    }
}
