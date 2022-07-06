using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditSaleTypeConstraintItemCommandValidator : AbstractValidator<EditSaleTypeConstraintItemCommand>
    {
        public EditSaleTypeConstraintItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
