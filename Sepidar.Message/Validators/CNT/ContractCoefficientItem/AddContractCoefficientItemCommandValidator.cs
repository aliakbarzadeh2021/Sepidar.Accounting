using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractCoefficientItemCommandValidator : AbstractValidator<AddContractCoefficientItemCommand>
    {
        public AddContractCoefficientItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
