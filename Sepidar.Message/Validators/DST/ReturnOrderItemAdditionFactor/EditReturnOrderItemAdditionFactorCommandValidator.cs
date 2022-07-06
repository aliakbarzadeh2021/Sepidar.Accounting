using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReturnOrderItemAdditionFactorCommandValidator : AbstractValidator<EditReturnOrderItemAdditionFactorCommand>
    {
        public EditReturnOrderItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
