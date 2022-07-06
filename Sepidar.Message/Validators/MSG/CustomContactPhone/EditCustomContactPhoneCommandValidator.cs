using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditCustomContactPhoneCommandValidator : AbstractValidator<EditCustomContactPhoneCommand>
    {
        public EditCustomContactPhoneCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
