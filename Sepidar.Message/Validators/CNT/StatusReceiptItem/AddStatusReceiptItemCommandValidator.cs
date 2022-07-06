using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddStatusReceiptItemCommandValidator : AbstractValidator<AddStatusReceiptItemCommand>
    {
        public AddStatusReceiptItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
