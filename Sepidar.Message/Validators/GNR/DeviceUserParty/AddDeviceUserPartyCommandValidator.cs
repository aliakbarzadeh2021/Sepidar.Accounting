using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddDeviceUserPartyCommandValidator : AbstractValidator<AddDeviceUserPartyCommand>
    {
        public AddDeviceUserPartyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
