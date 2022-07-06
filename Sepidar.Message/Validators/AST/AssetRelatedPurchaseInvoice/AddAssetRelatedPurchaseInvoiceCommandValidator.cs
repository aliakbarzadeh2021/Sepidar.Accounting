using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddAssetRelatedPurchaseInvoiceCommandValidator : AbstractValidator<AddAssetRelatedPurchaseInvoiceCommand>
    {
        public AddAssetRelatedPurchaseInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
