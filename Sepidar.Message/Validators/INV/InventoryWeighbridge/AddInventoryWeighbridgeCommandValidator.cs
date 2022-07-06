using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInventoryWeighbridgeCommandValidator : AbstractValidator<AddInventoryWeighbridgeCommand>
    {
        public AddInventoryWeighbridgeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
