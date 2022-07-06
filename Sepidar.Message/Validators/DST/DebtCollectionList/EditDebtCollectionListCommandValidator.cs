using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditDebtCollectionListCommandValidator : AbstractValidator<EditDebtCollectionListCommand>
    {
        public EditDebtCollectionListCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
