using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddUnexecutedActReasonCommandValidator : AbstractValidator<AddUnexecutedActReasonCommand>
    {
        public AddUnexecutedActReasonCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
