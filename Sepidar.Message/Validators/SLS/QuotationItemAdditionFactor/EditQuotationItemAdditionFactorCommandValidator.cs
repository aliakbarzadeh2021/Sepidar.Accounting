using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditQuotationItemAdditionFactorCommandValidator : AbstractValidator<EditQuotationItemAdditionFactorCommand>
    {
        public EditQuotationItemAdditionFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
