using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditCommissionCalculationInvoiceCommandValidator : AbstractValidator<EditCommissionCalculationInvoiceCommand>
    {
        public EditCommissionCalculationInvoiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
