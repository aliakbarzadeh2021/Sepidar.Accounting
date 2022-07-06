using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditTemplateSchedulingCommandValidator : AbstractValidator<EditTemplateSchedulingCommand>
    {
        public EditTemplateSchedulingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
