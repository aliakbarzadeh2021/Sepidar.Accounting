using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPathPartyAddressCommandValidator : AbstractValidator<AddPathPartyAddressCommand>
    {
        public AddPathPartyAddressCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
