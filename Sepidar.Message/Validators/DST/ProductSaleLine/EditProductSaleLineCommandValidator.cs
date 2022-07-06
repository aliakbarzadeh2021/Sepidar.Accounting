using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditProductSaleLineCommandValidator : AbstractValidator<EditProductSaleLineCommand>
    {
        public EditProductSaleLineCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
