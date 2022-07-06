using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddGuaranteeOperationCommandValidator : AbstractValidator<AddGuaranteeOperationCommand>
    {
        public AddGuaranteeOperationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
