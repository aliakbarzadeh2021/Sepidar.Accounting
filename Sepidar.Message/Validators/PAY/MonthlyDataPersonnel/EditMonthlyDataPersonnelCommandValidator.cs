using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditMonthlyDataPersonnelCommandValidator : AbstractValidator<EditMonthlyDataPersonnelCommand>
    {
        public EditMonthlyDataPersonnelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
