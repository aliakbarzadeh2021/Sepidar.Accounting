using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddDebtCollectionListInvoiceCommandValidator : AbstractValidator<AddDebtCollectionListInvoiceCommand>
    {
        public AddDebtCollectionListInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
