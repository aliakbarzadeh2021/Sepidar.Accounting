using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPartyOpeningBalanceCommandValidator : AbstractValidator<AddPartyOpeningBalanceCommand>
    {
        public AddPartyOpeningBalanceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
