using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInvoiceBrokerCommandValidator : AbstractValidator<AddInvoiceBrokerCommand>
    {
        public AddInvoiceBrokerCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
