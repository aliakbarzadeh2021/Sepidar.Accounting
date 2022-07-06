using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInventoryPricingVoucherCommandValidator : AbstractValidator<EditInventoryPricingVoucherCommand>
    {
        public EditInventoryPricingVoucherCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
