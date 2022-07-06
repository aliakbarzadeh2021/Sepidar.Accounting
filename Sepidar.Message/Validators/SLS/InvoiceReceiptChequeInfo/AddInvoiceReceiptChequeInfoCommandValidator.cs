using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInvoiceReceiptChequeInfoCommandValidator : AbstractValidator<AddInvoiceReceiptChequeInfoCommand>
    {
        public AddInvoiceReceiptChequeInfoCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
