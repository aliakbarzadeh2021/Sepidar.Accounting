using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditCustomsClearanceItemCommandValidator : AbstractValidator<EditCustomsClearanceItemCommand>
    {
        public EditCustomsClearanceItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
