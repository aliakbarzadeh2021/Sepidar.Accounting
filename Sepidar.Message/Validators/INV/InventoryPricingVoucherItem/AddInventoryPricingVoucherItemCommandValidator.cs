using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInventoryPricingVoucherItemCommandValidator : AbstractValidator<AddInventoryPricingVoucherItemCommand>
    {
        public AddInventoryPricingVoucherItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
