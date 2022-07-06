using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditHotDistributionPathCommandValidator : AbstractValidator<EditHotDistributionPathCommand>
    {
        public EditHotDistributionPathCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
