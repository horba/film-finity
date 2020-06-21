using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using FluentValidation;

namespace WebAPI.Validations
{
    public class ValidateNewsAuthor : AbstractValidator<NewsAuthor>
    {
        public ValidateNewsAuthor()
        {
            RuleFor(n => n.FirstName)
                .NotEmpty();
            RuleFor(n => n.LastName)
                 .NotEmpty();
        }
    }
}
