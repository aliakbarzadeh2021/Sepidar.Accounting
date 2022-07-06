using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMarketingDiskettePartyMapperCommandValidator : AbstractValidator<AddMarketingDiskettePartyMapperCommand>
    {
        public AddMarketingDiskettePartyMapperCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
