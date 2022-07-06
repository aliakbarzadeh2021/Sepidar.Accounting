using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditProductSaleLineItemCommandValidator : AbstractValidator<EditProductSaleLineItemCommand>
    {
        public EditProductSaleLineItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
