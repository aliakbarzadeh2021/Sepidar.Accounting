using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInventoryDeliveryItemCommandValidator : AbstractValidator<AddInventoryDeliveryItemCommand>
    {
        public AddInventoryDeliveryItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
