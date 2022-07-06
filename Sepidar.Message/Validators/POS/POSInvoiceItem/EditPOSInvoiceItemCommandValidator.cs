using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPOSInvoiceItemCommandValidator : AbstractValidator<EditPOSInvoiceItemCommand>
    {
        public EditPOSInvoiceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
