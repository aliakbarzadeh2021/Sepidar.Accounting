using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddCheckDataParityItemCommandValidator : AbstractValidator<AddCheckDataParityItemCommand>
    {
        public AddCheckDataParityItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
