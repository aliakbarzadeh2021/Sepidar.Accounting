using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPurchaseInvoiceItemCommandValidator : AbstractValidator<EditPurchaseInvoiceItemCommand>
    {
        public EditPurchaseInvoiceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
