using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReturnedInvoiceItemAdditionFactorCommandValidator : AbstractValidator<EditReturnedInvoiceItemAdditionFactorCommand>
    {
        public EditReturnedInvoiceItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
