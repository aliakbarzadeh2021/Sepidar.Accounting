using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditCostPartTransactionCommandValidator : AbstractValidator<EditCostPartTransactionCommand>
    {
        public EditCostPartTransactionCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
