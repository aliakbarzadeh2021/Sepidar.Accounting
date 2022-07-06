using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPOSInvoiceCommandValidator : AbstractValidator<AddPOSInvoiceCommand>
    {
        public AddPOSInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
