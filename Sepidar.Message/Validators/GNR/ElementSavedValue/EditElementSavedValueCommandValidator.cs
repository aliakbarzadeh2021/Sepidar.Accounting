using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditElementSavedValueCommandValidator : AbstractValidator<EditElementSavedValueCommand>
    {
        public EditElementSavedValueCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
