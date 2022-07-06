using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddAutomaticBackupConfigCommandValidator : AbstractValidator<AddAutomaticBackupConfigCommand>
    {
        public AddAutomaticBackupConfigCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
