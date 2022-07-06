using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditBillOfLoadingCommandValidator : AbstractValidator<EditBillOfLoadingCommand>
    {
        public EditBillOfLoadingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
