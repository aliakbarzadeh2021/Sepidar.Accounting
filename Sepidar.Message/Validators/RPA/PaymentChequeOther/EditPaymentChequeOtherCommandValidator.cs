using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPaymentChequeOtherCommandValidator : AbstractValidator<EditPaymentChequeOtherCommand>
    {
        public EditPaymentChequeOtherCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
