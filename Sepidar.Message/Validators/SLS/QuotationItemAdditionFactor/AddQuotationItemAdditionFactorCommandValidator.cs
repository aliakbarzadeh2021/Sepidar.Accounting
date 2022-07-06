using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddQuotationItemAdditionFactorCommandValidator : AbstractValidator<AddQuotationItemAdditionFactorCommand>
    {
        public AddQuotationItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
