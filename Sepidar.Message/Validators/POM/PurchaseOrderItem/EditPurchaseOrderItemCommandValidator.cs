using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPurchaseOrderItemCommandValidator : AbstractValidator<EditPurchaseOrderItemCommand>
    {
        public EditPurchaseOrderItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
