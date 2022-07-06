using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddElementSavedValueCommandValidator : AbstractValidator<AddElementSavedValueCommand>
    {
        public AddElementSavedValueCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
