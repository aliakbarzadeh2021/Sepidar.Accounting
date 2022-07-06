using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditOutgoingMessageCommandValidator : AbstractValidator<EditOutgoingMessageCommand>
    {
        public EditOutgoingMessageCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
