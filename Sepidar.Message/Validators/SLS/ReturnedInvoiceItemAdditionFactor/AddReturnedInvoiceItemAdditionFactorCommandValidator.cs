using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddReturnedInvoiceItemAdditionFactorCommandValidator : AbstractValidator<AddReturnedInvoiceItemAdditionFactorCommand>
    {
        public AddReturnedInvoiceItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
