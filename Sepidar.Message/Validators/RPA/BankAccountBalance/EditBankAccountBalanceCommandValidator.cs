using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditBankAccountBalanceCommandValidator : AbstractValidator<EditBankAccountBalanceCommand>
    {
        public EditBankAccountBalanceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
