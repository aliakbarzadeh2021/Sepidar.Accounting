using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditCheckDataParityItemCommandValidator : AbstractValidator<EditCheckDataParityItemCommand>
    {
        public EditCheckDataParityItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
