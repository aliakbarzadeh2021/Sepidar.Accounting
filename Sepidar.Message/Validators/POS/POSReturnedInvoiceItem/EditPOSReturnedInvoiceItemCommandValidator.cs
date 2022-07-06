using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPOSReturnedInvoiceItemCommandValidator : AbstractValidator<EditPOSReturnedInvoiceItemCommand>
    {
        public EditPOSReturnedInvoiceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
