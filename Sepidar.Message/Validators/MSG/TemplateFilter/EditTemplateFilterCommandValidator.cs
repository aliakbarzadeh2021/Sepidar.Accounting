using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditTemplateFilterCommandValidator : AbstractValidator<EditTemplateFilterCommand>
    {
        public EditTemplateFilterCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
