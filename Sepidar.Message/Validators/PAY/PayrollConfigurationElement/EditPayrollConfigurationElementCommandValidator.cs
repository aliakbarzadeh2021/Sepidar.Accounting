using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPayrollConfigurationElementCommandValidator : AbstractValidator<EditPayrollConfigurationElementCommand>
    {
        public EditPayrollConfigurationElementCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
