using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddOrderCommandValidator : AbstractValidator<AddOrderCommand>
    {
        public AddOrderCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
