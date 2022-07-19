using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(Product => Product.Header)
     .NotEmpty().WithMessage("Başlik alanı boş geçilemez!");

            RuleFor(Product => Product.Content)
               .NotEmpty().WithMessage("içerik alanı boş geçilemez!");

        }
    }
}
