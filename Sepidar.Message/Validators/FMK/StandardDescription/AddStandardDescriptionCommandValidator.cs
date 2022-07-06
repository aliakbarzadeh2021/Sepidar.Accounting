using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddStandardDescriptionCommandValidator : AbstractValidator<AddStandardDescriptionCommand>
    {
        public AddStandardDescriptionCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
