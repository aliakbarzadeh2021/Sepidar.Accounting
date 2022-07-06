using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddProductSaleLineItemCommandValidator : AbstractValidator<AddProductSaleLineItemCommand>
    {
        public AddProductSaleLineItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
