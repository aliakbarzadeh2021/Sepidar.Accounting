using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPayrollConfigurationCommandValidator : AbstractValidator<EditPayrollConfigurationCommand>
    {
        public EditPayrollConfigurationCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
