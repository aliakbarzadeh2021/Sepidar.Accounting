using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddCustomsClearanceItemCommandValidator : AbstractValidator<AddCustomsClearanceItemCommand>
    {
        public AddCustomsClearanceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
