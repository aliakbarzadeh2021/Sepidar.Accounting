using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReturnedInvoiceItemCommandValidator : AbstractValidator<EditReturnedInvoiceItemCommand>
    {
        public EditReturnedInvoiceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
