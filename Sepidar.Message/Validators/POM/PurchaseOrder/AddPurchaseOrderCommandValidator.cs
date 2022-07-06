using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPurchaseOrderCommandValidator : AbstractValidator<AddPurchaseOrderCommand>
    {
        public AddPurchaseOrderCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
