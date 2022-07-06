using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPosSettlementReceiptCommandValidator : AbstractValidator<AddPosSettlementReceiptCommand>
    {
        public AddPosSettlementReceiptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
