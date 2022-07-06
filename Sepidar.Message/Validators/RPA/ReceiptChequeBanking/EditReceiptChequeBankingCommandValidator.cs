using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReceiptChequeBankingCommandValidator : AbstractValidator<EditReceiptChequeBankingCommand>
    {
        public EditReceiptChequeBankingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
