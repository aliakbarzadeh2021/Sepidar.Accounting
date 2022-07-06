using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPaymentChequeBankingItemCommandValidator : AbstractValidator<EditPaymentChequeBankingItemCommand>
    {
        public EditPaymentChequeBankingItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
