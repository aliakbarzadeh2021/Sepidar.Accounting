using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPOSReturnedInvoiceCommandValidator : AbstractValidator<AddPOSReturnedInvoiceCommand>
    {
        public AddPOSReturnedInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
