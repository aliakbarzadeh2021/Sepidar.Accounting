using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPayrollCalendarCommandValidator : AbstractValidator<AddPayrollCalendarCommand>
    {
        public AddPayrollCalendarCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
