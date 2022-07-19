using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class ProductCategoryValidator : AbstractValidator<ProductCategory>
    {
        public ProductCategoryValidator()
        {
            RuleFor(ProductCategory => ProductCategory.ProductCategoryName)
                .NotEmpty().WithMessage("Kategori alanı boş geçilemez!");

        }
    }
}
