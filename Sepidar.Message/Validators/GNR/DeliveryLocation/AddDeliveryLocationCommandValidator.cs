using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddDeliveryLocationCommandValidator : AbstractValidator<AddDeliveryLocationCommand>
    {
        public AddDeliveryLocationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
