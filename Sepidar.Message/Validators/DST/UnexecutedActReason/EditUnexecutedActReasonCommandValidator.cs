using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditUnexecutedActReasonCommandValidator : AbstractValidator<EditUnexecutedActReasonCommand>
    {
        public EditUnexecutedActReasonCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
