using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditAreaAndPathCommandValidator : AbstractValidator<EditAreaAndPathCommand>
    {
        public EditAreaAndPathCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
