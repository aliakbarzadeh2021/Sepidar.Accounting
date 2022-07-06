using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReceiptChequeHistoryCommandValidator : AbstractValidator<EditReceiptChequeHistoryCommand>
    {
        public EditReceiptChequeHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
