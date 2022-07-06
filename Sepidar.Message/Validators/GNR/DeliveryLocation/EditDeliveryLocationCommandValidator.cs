using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditDeliveryLocationCommandValidator : AbstractValidator<EditDeliveryLocationCommand>
    {
        public EditDeliveryLocationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
