using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddDailyHourMinuteCommandValidator : AbstractValidator<AddDailyHourMinuteCommand>
    {
        public AddDailyHourMinuteCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
