using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddOrderingFailureCommandValidator : AbstractValidator<AddOrderingFailureCommand>
    {
        public AddOrderingFailureCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
