using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditColdDistributionReturnedInvoiceCommandValidator : AbstractValidator<EditColdDistributionReturnedInvoiceCommand>
    {
        public EditColdDistributionReturnedInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
