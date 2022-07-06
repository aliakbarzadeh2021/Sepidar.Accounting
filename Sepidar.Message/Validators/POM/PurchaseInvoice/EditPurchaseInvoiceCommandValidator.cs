using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPurchaseInvoiceCommandValidator : AbstractValidator<EditPurchaseInvoiceCommand>
    {
        public EditPurchaseInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
