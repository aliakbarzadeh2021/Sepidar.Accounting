using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditDailyHourMinuteCommandValidator : AbstractValidator<EditDailyHourMinuteCommand>
    {
        public EditDailyHourMinuteCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
