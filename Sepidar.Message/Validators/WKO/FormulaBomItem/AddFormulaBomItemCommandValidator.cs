using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddFormulaBomItemCommandValidator : AbstractValidator<AddFormulaBomItemCommand>
    {
        public AddFormulaBomItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
