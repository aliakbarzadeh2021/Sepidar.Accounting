using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditExtraColumnDescriptionCommandValidator : AbstractValidator<EditExtraColumnDescriptionCommand>
    {
        public EditExtraColumnDescriptionCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
