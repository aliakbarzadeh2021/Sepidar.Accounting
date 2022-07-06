using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditAdditionFactorItemCommandValidator : AbstractValidator<EditAdditionFactorItemCommand>
    {
        public EditAdditionFactorItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
