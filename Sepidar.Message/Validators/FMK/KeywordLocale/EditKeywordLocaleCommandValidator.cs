using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditKeywordLocaleCommandValidator : AbstractValidator<EditKeywordLocaleCommand>
    {
        public EditKeywordLocaleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
