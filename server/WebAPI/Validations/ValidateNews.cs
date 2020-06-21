using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using FluentValidation;
using WebAPI.Validations;

namespace WebAPI.Validation 
{
    public class ValidateNews : AbstractValidator<News>
    {
        public ValidateNews()
        {
            RuleFor(n => n.Author)
                .NotNull()
                .SetValidator(new ValidateNewsAuthor());
            RuleFor(n => n.Content)
               .NotEmpty();
            RuleFor(n => n.PreviewImage)
                .NotEmpty();
            RuleForEach(n => n.NewsCategories)
                .NotNull();
            RuleForEach(n => n.NewsCategories).ChildRules(n => {
                n.RuleFor(n => n.Category).NotNull().SetValidator(new ValidateNewsCategory());
            });
        }
    }
}
