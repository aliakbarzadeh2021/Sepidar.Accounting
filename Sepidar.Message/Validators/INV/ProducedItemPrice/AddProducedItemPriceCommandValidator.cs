using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddProducedItemPriceCommandValidator : AbstractValidator<AddProducedItemPriceCommand>
    {
        public AddProducedItemPriceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
