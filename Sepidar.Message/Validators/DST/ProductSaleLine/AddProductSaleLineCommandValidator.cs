using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddProductSaleLineCommandValidator : AbstractValidator<AddProductSaleLineCommand>
    {
        public AddProductSaleLineCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
