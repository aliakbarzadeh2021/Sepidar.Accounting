using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPosSettlementReceiptCommandValidator : AbstractValidator<EditPosSettlementReceiptCommand>
    {
        public EditPosSettlementReceiptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
