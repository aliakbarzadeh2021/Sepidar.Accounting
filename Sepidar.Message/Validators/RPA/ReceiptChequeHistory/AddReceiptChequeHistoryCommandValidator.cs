using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddReceiptChequeHistoryCommandValidator : AbstractValidator<AddReceiptChequeHistoryCommand>
    {
        public AddReceiptChequeHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
