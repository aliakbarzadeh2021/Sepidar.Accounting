using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddUserReportsInvisibleCommandValidator : AbstractValidator<AddUserReportsInvisibleCommand>
    {
        public AddUserReportsInvisibleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
