using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddProductSaleLinePartyCommandValidator : AbstractValidator<AddProductSaleLinePartyCommand>
    {
        public AddProductSaleLinePartyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
