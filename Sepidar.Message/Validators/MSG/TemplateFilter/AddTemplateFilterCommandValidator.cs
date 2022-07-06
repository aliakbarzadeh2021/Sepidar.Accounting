using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddTemplateFilterCommandValidator : AbstractValidator<AddTemplateFilterCommand>
    {
        public AddTemplateFilterCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
