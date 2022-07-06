using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddCommissionCalculationXMLResultCommandValidator : AbstractValidator<AddCommissionCalculationXMLResultCommand>
    {
        public AddCommissionCalculationXMLResultCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
