using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInventoryBalancingItemCommandValidator : AbstractValidator<EditInventoryBalancingItemCommand>
    {
        public EditInventoryBalancingItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
