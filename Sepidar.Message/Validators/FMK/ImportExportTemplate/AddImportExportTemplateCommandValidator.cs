using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddImportExportTemplateCommandValidator : AbstractValidator<AddImportExportTemplateCommand>
    {
        public AddImportExportTemplateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
