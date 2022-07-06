using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddSalesLimitItemPartyCommandValidator : AbstractValidator<AddSalesLimitItemPartyCommand>
    {
        public AddSalesLimitItemPartyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
