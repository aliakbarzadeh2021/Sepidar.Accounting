using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInventoryPurchaseInvoiceCommandValidator : AbstractValidator<AddInventoryPurchaseInvoiceCommand>
    {
        public AddInventoryPurchaseInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
