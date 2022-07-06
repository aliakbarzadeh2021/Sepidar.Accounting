using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditQuotationCommissionBrokerCommandValidator : AbstractValidator<EditQuotationCommissionBrokerCommand>
    {
        public EditQuotationCommissionBrokerCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
