using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditMarketingDisketteCommandValidator : AbstractValidator<EditMarketingDisketteCommand>
    {
        public EditMarketingDisketteCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
