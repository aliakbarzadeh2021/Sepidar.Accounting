using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMarketingDisketteItemCommandValidator : AbstractValidator<AddMarketingDisketteItemCommand>
    {
        public AddMarketingDisketteItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
