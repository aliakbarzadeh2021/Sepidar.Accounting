using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPaymentChequeHistoryCommandValidator : AbstractValidator<AddPaymentChequeHistoryCommand>
    {
        public AddPaymentChequeHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
