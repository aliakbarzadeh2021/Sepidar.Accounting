using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddColdDistributionInvoiceCommandValidator : AbstractValidator<AddColdDistributionInvoiceCommand>
    {
        public AddColdDistributionInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
