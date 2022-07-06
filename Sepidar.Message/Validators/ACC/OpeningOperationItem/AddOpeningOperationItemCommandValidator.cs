using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddOpeningOperationItemCommandValidator : AbstractValidator<AddOpeningOperationItemCommand>
    {
        public AddOpeningOperationItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
