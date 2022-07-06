using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditCurrencyExchangeRateCommandValidator : AbstractValidator<EditCurrencyExchangeRateCommand>
    {
        public EditCurrencyExchangeRateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
