using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInventoryWeighbridgeConfigurationCommandValidator : AbstractValidator<EditInventoryWeighbridgeConfigurationCommand>
    {
        public EditInventoryWeighbridgeConfigurationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
