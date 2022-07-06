using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInvoiceCommissionBrokerCommandValidator : AbstractValidator<AddInvoiceCommissionBrokerCommand>
    {
        public AddInvoiceCommissionBrokerCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
