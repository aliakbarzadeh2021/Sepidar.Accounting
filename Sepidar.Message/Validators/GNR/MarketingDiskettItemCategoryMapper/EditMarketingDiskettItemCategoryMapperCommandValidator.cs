using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditMarketingDiskettItemCategoryMapperCommandValidator : AbstractValidator<EditMarketingDiskettItemCategoryMapperCommand>
    {
        public EditMarketingDiskettItemCategoryMapperCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
