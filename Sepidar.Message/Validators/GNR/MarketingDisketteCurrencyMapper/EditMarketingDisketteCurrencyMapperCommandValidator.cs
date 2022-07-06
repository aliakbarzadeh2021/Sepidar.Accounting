using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditMarketingDisketteCurrencyMapperCommandValidator : AbstractValidator<EditMarketingDisketteCurrencyMapperCommand>
    {
        public EditMarketingDisketteCurrencyMapperCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
