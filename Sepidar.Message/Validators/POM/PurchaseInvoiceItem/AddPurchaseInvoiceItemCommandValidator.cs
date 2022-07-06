using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPurchaseInvoiceItemCommandValidator : AbstractValidator<AddPurchaseInvoiceItemCommand>
    {
        public AddPurchaseInvoiceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
