using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPiofyAttendanceFactorMapperCommandValidator : AbstractValidator<EditPiofyAttendanceFactorMapperCommand>
    {
        public EditPiofyAttendanceFactorMapperCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
