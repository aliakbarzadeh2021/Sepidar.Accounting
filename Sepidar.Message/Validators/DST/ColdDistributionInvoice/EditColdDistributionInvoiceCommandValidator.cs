using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditColdDistributionInvoiceCommandValidator : AbstractValidator<EditColdDistributionInvoiceCommand>
    {
        public EditColdDistributionInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
