using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInvoiceItemAdditionFactorCommandValidator : AbstractValidator<AddInvoiceItemAdditionFactorCommand>
    {
        public AddInvoiceItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
