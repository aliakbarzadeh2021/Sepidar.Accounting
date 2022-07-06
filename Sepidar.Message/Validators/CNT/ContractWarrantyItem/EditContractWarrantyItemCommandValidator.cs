using FluentValidation;
using Sepidar.Message.Commands;
using Sepidar.Message.Extentions;
using System;

namespace Sepidar.Message.Validators
{
    public class EditContractWarrantyItemCommandValidator : AbstractValidator<EditContractWarrantyItemCommand>
    {
        public EditContractWarrantyItemCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
