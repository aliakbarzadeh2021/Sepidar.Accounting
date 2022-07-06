using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInventoryReceiptCommandValidator : AbstractValidator<AddInventoryReceiptCommand>
    {
        public AddInventoryReceiptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
