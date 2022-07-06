using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddDepreciationRuleCommandValidator : AbstractValidator<AddDepreciationRuleCommand>
    {
        public AddDepreciationRuleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
