using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractSupportingInsuranceCommandValidator : AbstractValidator<AddContractSupportingInsuranceCommand>
    {
        public AddContractSupportingInsuranceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
