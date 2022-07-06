using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddHotDistributionPathCommandValidator : AbstractValidator<AddHotDistributionPathCommand>
    {
        public AddHotDistributionPathCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
