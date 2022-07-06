using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditCommercialOrderItemCommandValidator : AbstractValidator<EditCommercialOrderItemCommand>
    {
        public EditCommercialOrderItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
