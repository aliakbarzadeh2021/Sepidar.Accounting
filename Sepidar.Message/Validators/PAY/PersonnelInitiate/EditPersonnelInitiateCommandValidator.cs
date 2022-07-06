using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPersonnelInitiateCommandValidator : AbstractValidator<EditPersonnelInitiateCommand>
    {
        public EditPersonnelInitiateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
