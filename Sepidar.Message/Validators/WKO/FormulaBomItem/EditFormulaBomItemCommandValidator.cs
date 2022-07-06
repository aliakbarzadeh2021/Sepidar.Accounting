using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditFormulaBomItemCommandValidator : AbstractValidator<EditFormulaBomItemCommand>
    {
        public EditFormulaBomItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
