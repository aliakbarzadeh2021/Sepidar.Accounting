using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditDLCommandValidator : AbstractValidator<EditDLCommand>
    {
        public EditDLCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
