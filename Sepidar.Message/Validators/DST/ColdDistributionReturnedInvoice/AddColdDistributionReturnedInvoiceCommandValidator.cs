using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddColdDistributionReturnedInvoiceCommandValidator : AbstractValidator<AddColdDistributionReturnedInvoiceCommand>
    {
        public AddColdDistributionReturnedInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
