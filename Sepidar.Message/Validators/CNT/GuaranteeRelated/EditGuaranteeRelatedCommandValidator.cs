using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditGuaranteeRelatedCommandValidator : AbstractValidator<EditGuaranteeRelatedCommand>
    {
        public EditGuaranteeRelatedCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
