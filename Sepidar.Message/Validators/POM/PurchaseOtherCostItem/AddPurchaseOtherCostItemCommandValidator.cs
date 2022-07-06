using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPurchaseOtherCostItemCommandValidator : AbstractValidator<AddPurchaseOtherCostItemCommand>
    {
        public AddPurchaseOtherCostItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
