using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInventoryReceiptItemCommandValidator : AbstractValidator<AddInventoryReceiptItemCommand>
    {
        public AddInventoryReceiptItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
