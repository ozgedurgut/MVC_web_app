using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior:AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name cannot be empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category description cannot be empty");
            RuleFor(x=> x.CategoryName).MinimumLength(3).WithMessage("Category name cannot be less than 3");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Please write a name shorter than 20 characters");
        }
    }
}
