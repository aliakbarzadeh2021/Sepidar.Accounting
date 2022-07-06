using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditVoucherItemTrackingCommandValidator : AbstractValidator<EditVoucherItemTrackingCommand>
    {
        public EditVoucherItemTrackingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
