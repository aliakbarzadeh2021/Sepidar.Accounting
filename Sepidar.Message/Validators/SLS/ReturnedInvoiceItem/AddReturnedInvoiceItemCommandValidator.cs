using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddReturnedInvoiceItemCommandValidator : AbstractValidator<AddReturnedInvoiceItemCommand>
    {
        public AddReturnedInvoiceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
