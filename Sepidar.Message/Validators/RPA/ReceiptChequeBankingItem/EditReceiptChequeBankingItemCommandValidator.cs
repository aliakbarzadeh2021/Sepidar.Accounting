using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReceiptChequeBankingItemCommandValidator : AbstractValidator<EditReceiptChequeBankingItemCommand>
    {
        public EditReceiptChequeBankingItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
