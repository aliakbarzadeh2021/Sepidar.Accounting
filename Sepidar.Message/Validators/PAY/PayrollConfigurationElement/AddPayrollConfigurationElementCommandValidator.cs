using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPayrollConfigurationElementCommandValidator : AbstractValidator<AddPayrollConfigurationElementCommand>
    {
        public AddPayrollConfigurationElementCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
