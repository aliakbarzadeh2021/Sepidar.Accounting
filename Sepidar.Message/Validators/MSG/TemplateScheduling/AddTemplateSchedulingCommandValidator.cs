using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddTemplateSchedulingCommandValidator : AbstractValidator<AddTemplateSchedulingCommand>
    {
        public AddTemplateSchedulingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
