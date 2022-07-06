using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditStatusCoefficientItemCommandValidator : AbstractValidator<EditStatusCoefficientItemCommand>
    {
        public EditStatusCoefficientItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
