using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPOSReturnedInvoiceItemCommandValidator : AbstractValidator<AddPOSReturnedInvoiceItemCommand>
    {
        public AddPOSReturnedInvoiceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
