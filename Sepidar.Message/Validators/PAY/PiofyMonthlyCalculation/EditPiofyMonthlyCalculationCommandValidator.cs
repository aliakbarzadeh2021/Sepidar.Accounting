using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPiofyMonthlyCalculationCommandValidator : AbstractValidator<EditPiofyMonthlyCalculationCommand>
    {
        public EditPiofyMonthlyCalculationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
