using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPurchaseOtherCostItemCommandValidator : AbstractValidator<EditPurchaseOtherCostItemCommand>
    {
        public EditPurchaseOtherCostItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
