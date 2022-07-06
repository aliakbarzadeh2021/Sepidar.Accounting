using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPartyOpeningBalanceCommandValidator : AbstractValidator<EditPartyOpeningBalanceCommand>
    {
        public EditPartyOpeningBalanceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
