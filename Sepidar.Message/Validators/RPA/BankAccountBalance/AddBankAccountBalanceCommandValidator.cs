using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddBankAccountBalanceCommandValidator : AbstractValidator<AddBankAccountBalanceCommand>
    {
        public AddBankAccountBalanceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
