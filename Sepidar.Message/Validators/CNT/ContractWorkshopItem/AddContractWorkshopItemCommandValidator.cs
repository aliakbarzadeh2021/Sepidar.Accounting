using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class AddContractWorkshopItemCommandValidator : AbstractValidator<AddContractWorkshopItemCommand>
    {
        public AddContractWorkshopItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
