using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddCommercialOrderItemCommandValidator : AbstractValidator<AddCommercialOrderItemCommand>
    {
        public AddCommercialOrderItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
