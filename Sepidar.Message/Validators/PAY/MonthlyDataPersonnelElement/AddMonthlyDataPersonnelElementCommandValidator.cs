using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMonthlyDataPersonnelElementCommandValidator : AbstractValidator<AddMonthlyDataPersonnelElementCommand>
    {
        public AddMonthlyDataPersonnelElementCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
