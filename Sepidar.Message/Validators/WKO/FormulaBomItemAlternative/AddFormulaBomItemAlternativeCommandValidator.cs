using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddFormulaBomItemAlternativeCommandValidator : AbstractValidator<AddFormulaBomItemAlternativeCommand>
    {
        public AddFormulaBomItemAlternativeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
