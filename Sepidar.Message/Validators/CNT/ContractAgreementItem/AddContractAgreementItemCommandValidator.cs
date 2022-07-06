using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractAgreementItemCommandValidator : AbstractValidator<AddContractAgreementItemCommand>
    {
        public AddContractAgreementItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
