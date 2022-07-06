using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditDeviceUserPartyCommandValidator : AbstractValidator<EditDeviceUserPartyCommand>
    {
        public EditDeviceUserPartyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
