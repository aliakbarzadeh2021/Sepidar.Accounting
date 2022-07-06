using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInventoryPurchaseInvoiceCommandValidator : AbstractValidator<EditInventoryPurchaseInvoiceCommand>
    {
        public EditInventoryPurchaseInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
