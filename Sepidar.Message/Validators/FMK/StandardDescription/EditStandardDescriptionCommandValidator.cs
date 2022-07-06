using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditStandardDescriptionCommandValidator : AbstractValidator<EditStandardDescriptionCommand>
    {
        public EditStandardDescriptionCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
