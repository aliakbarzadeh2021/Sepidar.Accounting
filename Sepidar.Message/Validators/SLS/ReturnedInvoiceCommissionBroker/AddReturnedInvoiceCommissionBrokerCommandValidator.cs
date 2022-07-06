using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddReturnedInvoiceCommissionBrokerCommandValidator : AbstractValidator<AddReturnedInvoiceCommissionBrokerCommand>
    {
        public AddReturnedInvoiceCommissionBrokerCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
