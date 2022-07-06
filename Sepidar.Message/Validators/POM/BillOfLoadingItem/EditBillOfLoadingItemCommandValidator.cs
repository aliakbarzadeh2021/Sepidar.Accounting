using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditBillOfLoadingItemCommandValidator : AbstractValidator<EditBillOfLoadingItemCommand>
    {
        public EditBillOfLoadingItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
