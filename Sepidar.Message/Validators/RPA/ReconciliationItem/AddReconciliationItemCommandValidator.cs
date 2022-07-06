using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddReconciliationItemCommandValidator : AbstractValidator<AddReconciliationItemCommand>
    {
        public AddReconciliationItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
