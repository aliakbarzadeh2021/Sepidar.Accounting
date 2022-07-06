using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddCommissionCalculationItemCommandValidator : AbstractValidator<AddCommissionCalculationItemCommand>
    {
        public AddCommissionCalculationItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
