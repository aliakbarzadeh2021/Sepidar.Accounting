using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditOrderingScheduleRecurrenceCommandValidator : AbstractValidator<EditOrderingScheduleRecurrenceCommand>
    {
        public EditOrderingScheduleRecurrenceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
