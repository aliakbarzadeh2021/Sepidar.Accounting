using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMarketingDisketteCurrencyMapperCommandValidator : AbstractValidator<AddMarketingDisketteCurrencyMapperCommand>
    {
        public AddMarketingDisketteCurrencyMapperCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
