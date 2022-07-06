using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditContractCoefficientItemCommandValidator : AbstractValidator<EditContractCoefficientItemCommand>
    {
        public EditContractCoefficientItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
