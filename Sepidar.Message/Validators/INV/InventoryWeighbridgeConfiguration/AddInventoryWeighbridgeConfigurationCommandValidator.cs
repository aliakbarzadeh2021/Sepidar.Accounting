using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInventoryWeighbridgeConfigurationCommandValidator : AbstractValidator<AddInventoryWeighbridgeConfigurationCommand>
    {
        public AddInventoryWeighbridgeConfigurationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
