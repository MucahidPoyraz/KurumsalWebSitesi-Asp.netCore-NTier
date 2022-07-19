using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(Message => Message.Name)
                .NotEmpty().WithMessage("isim  alanı boş geçilemez!");

            RuleFor(Message => Message.Email)
            .NotEmpty().WithMessage("Email alanı boş geçilemez!")
            .EmailAddress()
            .WithMessage("Geçerli bir e-posta değeri giriniz!").When(i => !string.IsNullOrEmpty(i.Email));

        }
    }
}
