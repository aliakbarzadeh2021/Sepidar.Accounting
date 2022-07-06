using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInsurancePolicyItemCommandValidator : AbstractValidator<AddInsurancePolicyItemCommand>
    {
        public AddInsurancePolicyItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
