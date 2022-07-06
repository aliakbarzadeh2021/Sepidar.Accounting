using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddHotDistributionInventoryDeliveryCommandValidator : AbstractValidator<AddHotDistributionInventoryDeliveryCommand>
    {
        public AddHotDistributionInventoryDeliveryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
