using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddReturnOrderItemAdditionFactorCommandValidator : AbstractValidator<AddReturnOrderItemAdditionFactorCommand>
    {
        public AddReturnOrderItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
