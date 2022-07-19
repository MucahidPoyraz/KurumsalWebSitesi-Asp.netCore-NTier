using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class PersonelValidator : AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(Personel => Personel.PersonelNameSurname)
                .NotEmpty().WithMessage("isim Soyisim alanı boş geçilemez!");



            RuleFor(Personel => Personel.DepartmentId)
                .NotEmpty().WithMessage("Departman  alanı boş geçilemez!");

            RuleFor(Personel => Personel.Content)
                .NotEmpty().WithMessage("İçerik alanı boş geçilemez!");

        }
    }
}
