using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddAcquisitionReceiptItemCommandValidator : AbstractValidator<AddAcquisitionReceiptItemCommand>
    {
        public AddAcquisitionReceiptItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
