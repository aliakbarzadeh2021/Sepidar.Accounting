using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMarketingDisketteCurrencyCommandValidator : AbstractValidator<AddMarketingDisketteCurrencyCommand>
    {
        public AddMarketingDisketteCurrencyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
