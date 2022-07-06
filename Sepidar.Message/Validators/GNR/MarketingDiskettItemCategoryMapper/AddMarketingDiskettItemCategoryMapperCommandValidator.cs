using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddMarketingDiskettItemCategoryMapperCommandValidator : AbstractValidator<AddMarketingDiskettItemCategoryMapperCommand>
    {
        public AddMarketingDiskettItemCategoryMapperCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
