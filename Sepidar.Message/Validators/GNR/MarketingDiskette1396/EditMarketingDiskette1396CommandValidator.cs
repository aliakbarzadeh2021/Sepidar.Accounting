using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditMarketingDiskette1396CommandValidator : AbstractValidator<EditMarketingDiskette1396Command>
    {
        public EditMarketingDiskette1396CommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
