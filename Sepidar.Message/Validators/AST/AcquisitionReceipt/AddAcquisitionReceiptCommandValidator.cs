using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddAcquisitionReceiptCommandValidator : AbstractValidator<AddAcquisitionReceiptCommand>
    {
        public AddAcquisitionReceiptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
