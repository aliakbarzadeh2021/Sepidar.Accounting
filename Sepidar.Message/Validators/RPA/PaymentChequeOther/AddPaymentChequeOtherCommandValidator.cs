using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPaymentChequeOtherCommandValidator : AbstractValidator<AddPaymentChequeOtherCommand>
    {
        public AddPaymentChequeOtherCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
