using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPartyAccountSettlementCommandValidator : AbstractValidator<AddPartyAccountSettlementCommand>
    {
        public AddPartyAccountSettlementCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
