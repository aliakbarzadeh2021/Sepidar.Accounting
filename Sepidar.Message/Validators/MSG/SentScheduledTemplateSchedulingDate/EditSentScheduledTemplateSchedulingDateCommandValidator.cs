using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditSentScheduledTemplateSchedulingDateCommandValidator : AbstractValidator<EditSentScheduledTemplateSchedulingDateCommand>
    {
        public EditSentScheduledTemplateSchedulingDateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
