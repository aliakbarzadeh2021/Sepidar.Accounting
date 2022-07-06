using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditAcquisitionReceiptItemCommandValidator : AbstractValidator<EditAcquisitionReceiptItemCommand>
    {
        public EditAcquisitionReceiptItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
