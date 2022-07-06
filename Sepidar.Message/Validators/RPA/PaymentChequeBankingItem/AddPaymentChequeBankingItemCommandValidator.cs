using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPaymentChequeBankingItemCommandValidator : AbstractValidator<AddPaymentChequeBankingItemCommand>
    {
        public AddPaymentChequeBankingItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
