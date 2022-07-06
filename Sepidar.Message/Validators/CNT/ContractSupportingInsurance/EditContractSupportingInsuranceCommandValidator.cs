using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditContractSupportingInsuranceCommandValidator : AbstractValidator<EditContractSupportingInsuranceCommand>
    {
        public EditContractSupportingInsuranceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
