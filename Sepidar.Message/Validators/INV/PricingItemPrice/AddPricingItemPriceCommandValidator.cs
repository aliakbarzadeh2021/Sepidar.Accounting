using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPricingItemPriceCommandValidator : AbstractValidator<AddPricingItemPriceCommand>
    {
        public AddPricingItemPriceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
