using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPartyAccountSettlementItemCommandValidator : AbstractValidator<EditPartyAccountSettlementItemCommand>
    {
        public EditPartyAccountSettlementItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
