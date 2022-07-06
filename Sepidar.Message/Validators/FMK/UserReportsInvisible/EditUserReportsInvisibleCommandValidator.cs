using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditUserReportsInvisibleCommandValidator : AbstractValidator<EditUserReportsInvisibleCommand>
    {
        public EditUserReportsInvisibleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
