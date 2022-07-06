using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPayrollConfigurationCommandValidator : AbstractValidator<AddPayrollConfigurationCommand>
    {
        public AddPayrollConfigurationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
