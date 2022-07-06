using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditOrderItemAdditionFactorCommandValidator : AbstractValidator<EditOrderItemAdditionFactorCommand>
    {
        public EditOrderItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
