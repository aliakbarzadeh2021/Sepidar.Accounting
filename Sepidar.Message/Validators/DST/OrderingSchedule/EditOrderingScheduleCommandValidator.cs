using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditOrderingScheduleCommandValidator : AbstractValidator<EditOrderingScheduleCommand>
    {
        public EditOrderingScheduleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
