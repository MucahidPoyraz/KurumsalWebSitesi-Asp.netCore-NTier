using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(Contact => Contact.Address)
         .NotEmpty().WithMessage("Adres alanı boş geçilemez!")
         .MinimumLength(5).WithMessage("Adres alanı min 5 kareketer olmalıdır!");

            RuleFor(Contact => Contact.PhoneOne)
         .NotEmpty().WithMessage("Telefon alanı boş geçilemez!");



            RuleFor(Contact => Contact.EmailOne)
            .NotEmpty().WithMessage("Email alanı boş geçilemez");



            RuleFor(Contact => Contact.MapLink)
         .NotEmpty().WithMessage("Harita alanı boş geçilemez!");



        }
    }
}
