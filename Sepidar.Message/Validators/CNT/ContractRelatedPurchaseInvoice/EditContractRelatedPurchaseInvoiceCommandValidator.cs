using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditContractRelatedPurchaseInvoiceCommandValidator : AbstractValidator<EditContractRelatedPurchaseInvoiceCommand>
    {
        public EditContractRelatedPurchaseInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
