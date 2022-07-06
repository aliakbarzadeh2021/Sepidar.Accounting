using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddVoucherItemTrackingCommandValidator : AbstractValidator<AddVoucherItemTrackingCommand>
    {
        public AddVoucherItemTrackingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
