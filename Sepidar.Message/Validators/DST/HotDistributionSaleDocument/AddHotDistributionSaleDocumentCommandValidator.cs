using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddHotDistributionSaleDocumentCommandValidator : AbstractValidator<AddHotDistributionSaleDocumentCommand>
    {
        public AddHotDistributionSaleDocumentCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
