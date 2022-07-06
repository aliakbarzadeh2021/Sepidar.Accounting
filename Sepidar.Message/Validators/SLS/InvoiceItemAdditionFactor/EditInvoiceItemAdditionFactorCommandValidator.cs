using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInvoiceItemAdditionFactorCommandValidator : AbstractValidator<EditInvoiceItemAdditionFactorCommand>
    {
        public EditInvoiceItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
