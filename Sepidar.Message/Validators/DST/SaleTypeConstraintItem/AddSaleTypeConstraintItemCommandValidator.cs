using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddSaleTypeConstraintItemCommandValidator : AbstractValidator<AddSaleTypeConstraintItemCommand>
    {
        public AddSaleTypeConstraintItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
