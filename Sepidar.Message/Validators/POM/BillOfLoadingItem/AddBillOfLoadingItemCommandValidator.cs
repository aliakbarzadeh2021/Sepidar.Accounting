using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddBillOfLoadingItemCommandValidator : AbstractValidator<AddBillOfLoadingItemCommand>
    {
        public AddBillOfLoadingItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
