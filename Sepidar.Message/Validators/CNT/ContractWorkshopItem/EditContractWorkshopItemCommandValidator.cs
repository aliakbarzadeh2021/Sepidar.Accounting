using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditContractWorkshopItemCommandValidator : AbstractValidator<EditContractWorkshopItemCommand>
    {
        public EditContractWorkshopItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
