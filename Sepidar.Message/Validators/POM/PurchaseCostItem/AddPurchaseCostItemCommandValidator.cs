using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPurchaseCostItemCommandValidator : AbstractValidator<AddPurchaseCostItemCommand>
    {
        public AddPurchaseCostItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
