using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddPersonnelTaxFileInfoChangeLogCommandValidator : AbstractValidator<AddPersonnelTaxFileInfoChangeLogCommand>
    {
        public AddPersonnelTaxFileInfoChangeLogCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
