using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditReturnedInvoiceCommissionBrokerCommandValidator : AbstractValidator<EditReturnedInvoiceCommissionBrokerCommand>
    {
        public EditReturnedInvoiceCommissionBrokerCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
