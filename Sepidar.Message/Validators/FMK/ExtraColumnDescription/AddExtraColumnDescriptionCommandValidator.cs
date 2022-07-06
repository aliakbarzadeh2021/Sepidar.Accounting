using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddExtraColumnDescriptionCommandValidator : AbstractValidator<AddExtraColumnDescriptionCommand>
    {
        public AddExtraColumnDescriptionCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
