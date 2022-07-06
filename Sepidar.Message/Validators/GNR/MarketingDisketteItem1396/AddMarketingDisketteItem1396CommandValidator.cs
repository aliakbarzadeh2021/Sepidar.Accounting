using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMarketingDisketteItem1396CommandValidator : AbstractValidator<AddMarketingDisketteItem1396Command>
    {
        public AddMarketingDisketteItem1396CommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
