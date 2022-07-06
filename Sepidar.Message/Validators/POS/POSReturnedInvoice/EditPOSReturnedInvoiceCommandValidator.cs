using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPOSReturnedInvoiceCommandValidator : AbstractValidator<EditPOSReturnedInvoiceCommand>
    {
        public EditPOSReturnedInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
