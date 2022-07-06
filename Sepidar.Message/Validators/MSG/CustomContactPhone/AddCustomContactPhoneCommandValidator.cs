using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddCustomContactPhoneCommandValidator : AbstractValidator<AddCustomContactPhoneCommand>
    {
        public AddCustomContactPhoneCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
