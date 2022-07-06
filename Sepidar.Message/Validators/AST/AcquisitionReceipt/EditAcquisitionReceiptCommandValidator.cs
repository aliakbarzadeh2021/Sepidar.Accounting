using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditAcquisitionReceiptCommandValidator : AbstractValidator<EditAcquisitionReceiptCommand>
    {
        public EditAcquisitionReceiptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
