using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditProductPackDiscountCommandValidator : AbstractValidator<EditProductPackDiscountCommand>
    {
        public EditProductPackDiscountCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
