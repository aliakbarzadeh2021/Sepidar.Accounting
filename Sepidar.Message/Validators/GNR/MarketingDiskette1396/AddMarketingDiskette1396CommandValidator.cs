using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMarketingDiskette1396CommandValidator : AbstractValidator<AddMarketingDiskette1396Command>
    {
        public AddMarketingDiskette1396CommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
