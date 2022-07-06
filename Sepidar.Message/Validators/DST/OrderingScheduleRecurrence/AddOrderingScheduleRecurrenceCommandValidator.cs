using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddOrderingScheduleRecurrenceCommandValidator : AbstractValidator<AddOrderingScheduleRecurrenceCommand>
    {
        public AddOrderingScheduleRecurrenceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
