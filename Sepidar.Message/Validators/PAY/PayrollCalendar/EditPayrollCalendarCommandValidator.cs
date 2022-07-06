using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPayrollCalendarCommandValidator : AbstractValidator<EditPayrollCalendarCommand>
    {
        public EditPayrollCalendarCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
