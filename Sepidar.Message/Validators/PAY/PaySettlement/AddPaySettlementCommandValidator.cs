using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPaySettlementCommandValidator : AbstractValidator<AddPaySettlementCommand>
    {
        public AddPaySettlementCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
