using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddCompoundBarcodeCommandValidator : AbstractValidator<AddCompoundBarcodeCommand>
    {
        public AddCompoundBarcodeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
