using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditMarketingDisketteItem1396CommandValidator : AbstractValidator<EditMarketingDisketteItem1396Command>
    {
        public EditMarketingDisketteItem1396CommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
