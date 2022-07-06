using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPaymentChequeBankingCommandValidator : AbstractValidator<AddPaymentChequeBankingCommand>
    {
        public AddPaymentChequeBankingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
