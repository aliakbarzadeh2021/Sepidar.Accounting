using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReceiptHeaderCommandValidator : AbstractValidator<EditReceiptHeaderCommand>
    {
        public EditReceiptHeaderCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
