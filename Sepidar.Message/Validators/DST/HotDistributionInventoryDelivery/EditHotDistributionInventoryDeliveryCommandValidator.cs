using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditHotDistributionInventoryDeliveryCommandValidator : AbstractValidator<EditHotDistributionInventoryDeliveryCommand>
    {
        public EditHotDistributionInventoryDeliveryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
