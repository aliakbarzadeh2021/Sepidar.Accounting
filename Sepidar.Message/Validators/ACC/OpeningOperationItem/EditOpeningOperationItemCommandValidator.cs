using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditOpeningOperationItemCommandValidator : AbstractValidator<EditOpeningOperationItemCommand>
    {
        public EditOpeningOperationItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
