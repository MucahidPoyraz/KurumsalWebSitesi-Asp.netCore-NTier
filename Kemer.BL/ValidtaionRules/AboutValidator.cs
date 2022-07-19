using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(About => About.MissionContent)
         .NotEmpty().WithMessage("Misyon alanı boş geçilemez!").Length(5, 200).WithMessage("Visyon alanı 5 ile 200 karakter arasında olmalıdır!");

            RuleFor(About => About.VisionContent)
            .NotEmpty().WithMessage("Visyon alanı boş geçilemez!")
            .Length(5, 200).WithMessage("Visyon alanı 5 ile 200 karakter arasında olmalıdır!");

            RuleFor(About => About.OurGoalContent)
           .NotEmpty().WithMessage("Hedefler alanı boş geçilemez!")
            .Length(5, 200).WithMessage("Hedefler alanı 5 ile 200 karakter arasında olmalıdır!");
        }


    }
}
