using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInventoryPurchaseInvoiceItemCommandValidator : AbstractValidator<EditInventoryPurchaseInvoiceItemCommand>
    {
        public EditInventoryPurchaseInvoiceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
