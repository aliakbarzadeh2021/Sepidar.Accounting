using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddQuotationCommissionBrokerCommandValidator : AbstractValidator<AddQuotationCommissionBrokerCommand>
    {
        public AddQuotationCommissionBrokerCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
