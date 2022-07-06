using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddInsurancePolicyCommandValidator : AbstractValidator<AddInsurancePolicyCommand>
    {
        public AddInsurancePolicyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
