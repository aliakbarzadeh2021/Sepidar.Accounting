using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPiofyAttendanceFactorCommandValidator : AbstractValidator<AddPiofyAttendanceFactorCommand>
    {
        public AddPiofyAttendanceFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
