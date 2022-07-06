using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditInvoiceCommissionBrokerCommandValidator : AbstractValidator<EditInvoiceCommissionBrokerCommand>
    {
        public EditInvoiceCommissionBrokerCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
