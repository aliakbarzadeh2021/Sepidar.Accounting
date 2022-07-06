using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddDebtCollectionListCommandValidator : AbstractValidator<AddDebtCollectionListCommand>
    {
        public AddDebtCollectionListCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
