using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace WebAPI.Validations
{
    public class ValidateNewsCategory : AbstractValidator<NewsCategory>
    {
        public ValidateNewsCategory()
        {
            RuleFor(n => n.Name)
                .NotEmpty();
        }
    }
}
