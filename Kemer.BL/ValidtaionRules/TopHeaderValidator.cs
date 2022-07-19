
using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class TopHeaderValidator : AbstractValidator<TopHeader>
    {
        public TopHeaderValidator()
        {
            RuleFor(TopHeader => TopHeader.SloganOne)
                .NotEmpty().WithMessage("Bu Slogan  alanı boş geçilemez!")
                .Length(5, 100).WithMessage("Slogan alanı 5 ile 100 karakter arasında olmalıdır!");

            RuleFor(TopHeader => TopHeader.SloganTwo)
                .NotEmpty().WithMessage("Bu Slogan alanı boş geçilemez!")
                .Length(5, 100).WithMessage("Slogan alanı 5 ile 100 karakter arasında olmalıdır!");



        }
    }
}
