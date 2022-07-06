using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPiofyAttendanceFactorCommandValidator : AbstractValidator<EditPiofyAttendanceFactorCommand>
    {
        public EditPiofyAttendanceFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
