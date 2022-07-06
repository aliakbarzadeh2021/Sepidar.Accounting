using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInventoryPricingVoucherCommandValidator : AbstractValidator<AddInventoryPricingVoucherCommand>
    {
        public AddInventoryPricingVoucherCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
