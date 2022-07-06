using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddOrderingFailureItemCommandValidator : AbstractValidator<AddOrderingFailureItemCommand>
    {
        public AddOrderingFailureItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
