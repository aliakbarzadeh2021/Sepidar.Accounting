using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInvoiceReceiptInfoCommandValidator : AbstractValidator<EditInvoiceReceiptInfoCommand>
    {
        public EditInvoiceReceiptInfoCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
