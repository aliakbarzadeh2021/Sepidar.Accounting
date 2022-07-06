using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReturnOrderItemCommandValidator : AbstractValidator<EditReturnOrderItemCommand>
    {
        public EditReturnOrderItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
