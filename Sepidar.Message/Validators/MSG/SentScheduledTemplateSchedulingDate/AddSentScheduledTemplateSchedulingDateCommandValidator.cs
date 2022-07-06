using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddSentScheduledTemplateSchedulingDateCommandValidator : AbstractValidator<AddSentScheduledTemplateSchedulingDateCommand>
    {
        public AddSentScheduledTemplateSchedulingDateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
