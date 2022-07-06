using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddRefundChequeItemCommandValidator : AbstractValidator<AddRefundChequeItemCommand>
    {
        public AddRefundChequeItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
