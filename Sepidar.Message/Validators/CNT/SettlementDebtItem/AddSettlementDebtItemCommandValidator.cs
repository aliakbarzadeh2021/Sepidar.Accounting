using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddSettlementDebtItemCommandValidator : AbstractValidator<AddSettlementDebtItemCommand>
    {
        public AddSettlementDebtItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
