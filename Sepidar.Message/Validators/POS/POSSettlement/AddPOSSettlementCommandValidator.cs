using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPOSSettlementCommandValidator : AbstractValidator<AddPOSSettlementCommand>
    {
        public AddPOSSettlementCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
