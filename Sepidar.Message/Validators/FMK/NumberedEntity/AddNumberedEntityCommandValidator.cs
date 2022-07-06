using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddNumberedEntityCommandValidator : AbstractValidator<AddNumberedEntityCommand>
    {
        public AddNumberedEntityCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
