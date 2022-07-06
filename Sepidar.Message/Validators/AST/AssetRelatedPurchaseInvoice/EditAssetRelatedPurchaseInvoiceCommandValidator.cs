using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditAssetRelatedPurchaseInvoiceCommandValidator : AbstractValidator<EditAssetRelatedPurchaseInvoiceCommand>
    {
        public EditAssetRelatedPurchaseInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
