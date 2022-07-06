using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditImportExportTemplateCommandValidator : AbstractValidator<EditImportExportTemplateCommand>
    {
        public EditImportExportTemplateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
