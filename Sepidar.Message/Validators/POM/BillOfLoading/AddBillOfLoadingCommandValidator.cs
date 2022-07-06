using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddBillOfLoadingCommandValidator : AbstractValidator<AddBillOfLoadingCommand>
    {
        public AddBillOfLoadingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
