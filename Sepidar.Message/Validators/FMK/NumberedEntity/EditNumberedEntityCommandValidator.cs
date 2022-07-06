using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditNumberedEntityCommandValidator : AbstractValidator<EditNumberedEntityCommand>
    {
        public EditNumberedEntityCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
