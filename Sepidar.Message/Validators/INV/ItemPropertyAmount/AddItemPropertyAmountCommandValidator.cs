using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddItemPropertyAmountCommandValidator : AbstractValidator<AddItemPropertyAmountCommand>
    {
        public AddItemPropertyAmountCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
