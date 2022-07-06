using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractRelatedPurchaseInvoiceCommandValidator : AbstractValidator<AddContractRelatedPurchaseInvoiceCommand>
    {
        public AddContractRelatedPurchaseInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
