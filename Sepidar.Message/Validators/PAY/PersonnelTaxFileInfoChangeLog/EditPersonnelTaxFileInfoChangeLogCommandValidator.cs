using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditPersonnelTaxFileInfoChangeLogCommandValidator : AbstractValidator<EditPersonnelTaxFileInfoChangeLogCommand>
    {
        public EditPersonnelTaxFileInfoChangeLogCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
