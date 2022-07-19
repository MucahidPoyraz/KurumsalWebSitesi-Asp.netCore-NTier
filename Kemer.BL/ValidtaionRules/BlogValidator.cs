using FluentValidation;
using Kemer.Entities.Concrete;

namespace Kemer.BL.ValidtaionRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {


            RuleFor(Blog => Blog.BlogCategoryId)
        .NotEmpty().WithMessage("katergori alanı boş geçilemez!");

            RuleFor(Blog => Blog.AuthorName)
       .NotEmpty().WithMessage("Yazar ismi alanı boş geçilemez!");

            RuleFor(Blog => Blog.Header)
       .NotEmpty().WithMessage("Başlik alanı boş geçilemez!");

            RuleFor(Blog => Blog.SubTitle)
       .NotEmpty().WithMessage("Alt Başlik alanı boş geçilemez!");

            RuleFor(Blog => Blog.ContentOne)
       .NotEmpty().WithMessage("Bu İçerik alanı boş geçilemez!");


        }
    }
}
