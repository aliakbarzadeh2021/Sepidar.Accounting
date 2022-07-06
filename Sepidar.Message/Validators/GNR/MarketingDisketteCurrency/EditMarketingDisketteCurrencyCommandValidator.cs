using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditMarketingDisketteCurrencyCommandValidator : AbstractValidator<EditMarketingDisketteCurrencyCommand>
    {
        public EditMarketingDisketteCurrencyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
