using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInventoryBalancingCommandValidator : AbstractValidator<EditInventoryBalancingCommand>
    {
        public EditInventoryBalancingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
