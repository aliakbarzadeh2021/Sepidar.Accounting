using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditItemStockSummaryCommandValidator : AbstractValidator<EditItemStockSummaryCommand>
    {
        public EditItemStockSummaryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
