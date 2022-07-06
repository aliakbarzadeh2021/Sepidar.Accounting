using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInventoryPricingVoucherItemCommandValidator : AbstractValidator<EditInventoryPricingVoucherItemCommand>
    {
        public EditInventoryPricingVoucherItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
