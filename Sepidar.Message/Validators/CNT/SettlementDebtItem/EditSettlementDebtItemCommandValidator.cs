using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditSettlementDebtItemCommandValidator : AbstractValidator<EditSettlementDebtItemCommand>
    {
        public EditSettlementDebtItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
