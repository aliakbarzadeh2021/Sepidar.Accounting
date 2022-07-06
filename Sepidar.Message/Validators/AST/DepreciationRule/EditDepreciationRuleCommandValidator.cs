using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditDepreciationRuleCommandValidator : AbstractValidator<EditDepreciationRuleCommand>
    {
        public EditDepreciationRuleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
