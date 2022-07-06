using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditSaleTypeConstraintCommandValidator : AbstractValidator<EditSaleTypeConstraintCommand>
    {
        public EditSaleTypeConstraintCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
