using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditHotDistributionUnexecutedActCommandValidator : AbstractValidator<EditHotDistributionUnexecutedActCommand>
    {
        public EditHotDistributionUnexecutedActCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
