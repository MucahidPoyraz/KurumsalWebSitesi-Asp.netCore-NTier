using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class BlogCategoryValidator : AbstractValidator<BlogCategory>
    {
        public BlogCategoryValidator()
        {
            RuleFor(BlogCategory => BlogCategory.BlogCategoryName)
         .NotEmpty().WithMessage("Kategori İsim alanı boş geçilemez!")
         .Length(1, 20).WithMessage("İsim alanı 1 ile 20 karakter arasında olmalıdır!");




        }
    }
}
