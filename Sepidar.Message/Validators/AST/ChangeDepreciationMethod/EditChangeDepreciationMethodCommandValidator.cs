using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditChangeDepreciationMethodCommandValidator : AbstractValidator<EditChangeDepreciationMethodCommand>
    {
        public EditChangeDepreciationMethodCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
