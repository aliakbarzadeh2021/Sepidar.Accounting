using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditGLVoucherItemCommandValidator : AbstractValidator<EditGLVoucherItemCommand>
    {
        public EditGLVoucherItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
