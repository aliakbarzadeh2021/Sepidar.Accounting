using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditCommissionCalculationXMLResultCommandValidator : AbstractValidator<EditCommissionCalculationXMLResultCommand>
    {
        public EditCommissionCalculationXMLResultCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
