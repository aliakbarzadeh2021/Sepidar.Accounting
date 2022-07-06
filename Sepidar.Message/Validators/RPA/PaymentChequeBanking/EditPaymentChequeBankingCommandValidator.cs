using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPaymentChequeBankingCommandValidator : AbstractValidator<EditPaymentChequeBankingCommand>
    {
        public EditPaymentChequeBankingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
