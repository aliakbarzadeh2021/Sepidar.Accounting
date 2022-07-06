using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMonthlyDataPersonnelCommandValidator : AbstractValidator<AddMonthlyDataPersonnelCommand>
    {
        public AddMonthlyDataPersonnelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
