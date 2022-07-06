using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditGuaranteeOperationCommandValidator : AbstractValidator<EditGuaranteeOperationCommand>
    {
        public EditGuaranteeOperationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
