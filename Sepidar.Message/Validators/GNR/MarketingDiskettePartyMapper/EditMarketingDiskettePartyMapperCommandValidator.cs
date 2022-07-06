using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditMarketingDiskettePartyMapperCommandValidator : AbstractValidator<EditMarketingDiskettePartyMapperCommand>
    {
        public EditMarketingDiskettePartyMapperCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
