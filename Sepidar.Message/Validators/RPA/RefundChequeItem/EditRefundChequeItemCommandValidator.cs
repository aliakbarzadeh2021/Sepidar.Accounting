using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditRefundChequeItemCommandValidator : AbstractValidator<EditRefundChequeItemCommand>
    {
        public EditRefundChequeItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
