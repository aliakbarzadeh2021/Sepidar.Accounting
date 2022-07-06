using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddOutgoingMessageCommandValidator : AbstractValidator<AddOutgoingMessageCommand>
    {
        public AddOutgoingMessageCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
