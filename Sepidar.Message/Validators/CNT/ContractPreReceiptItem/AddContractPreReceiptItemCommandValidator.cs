using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractPreReceiptItemCommandValidator : AbstractValidator<AddContractPreReceiptItemCommand>
    {
        public AddContractPreReceiptItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
