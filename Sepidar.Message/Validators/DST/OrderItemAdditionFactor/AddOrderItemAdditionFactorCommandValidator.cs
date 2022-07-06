using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddOrderItemAdditionFactorCommandValidator : AbstractValidator<AddOrderItemAdditionFactorCommand>
    {
        public AddOrderItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
