using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPaymentHeaderCommandValidator : AbstractValidator<EditPaymentHeaderCommand>
    {
        public EditPaymentHeaderCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
